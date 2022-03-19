using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooPark.Data;

namespace ZooPark.Forms
{
    public partial class FoodAddUpdate : Form
    {
        private readonly ApplicationDbContext db;
        Food food;

        public FoodAddUpdate(ApplicationDbContext db)
        {      
            this.db = db;
            InitializeComponent();
        }

        private void btnFoodAddUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoodName.Text) && nudCalories.Value == 0.0m)
            {
                MessageBox.Show("Please feel all the areas");
                return;
            }
            food = new Food();
            food.Name = txtFoodName.Text.Trim();
            food.ManufactureDate = dtpManufactureDate.Value;
            food.ExpirationDate = dtpExpirationDate.Value;
            food.Calories = nudCalories.Value;
            db.Food.Add(food);
            db.SaveChanges();
            MessageBox.Show("Food successfully added");
            Close();
        }
    }
}
