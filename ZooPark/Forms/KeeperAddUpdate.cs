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
    public partial class KeeperAddUpdate : Form
    {
        private readonly Keeper keeper;
        private readonly ApplicationDbContext db;

        public KeeperAddUpdate(ApplicationDbContext db)
        {
            this.db = db;
            InitializeComponent();
            btnAnimalAddUpdate.Text = "Add";

        }
        public KeeperAddUpdate(Keeper keeper, ApplicationDbContext db)
        {
            this.keeper = keeper;
            this.db = db;
            InitializeComponent();
            btnAnimalAddUpdate.Text = "Update";
            txtKeeperName.Text = keeper.Name;
            txtKeeperSurname.Text = keeper.SurName;
        }


        private void btnAnimalAddUpdate_Click(object sender, EventArgs e)
        {
            if (btnAnimalAddUpdate.Text == "Add")
            {
                AddKeeper();
            }
            else
            {
                EditKeeper();
            }
        }
        private void AddKeeper()
        {
            if (txtKeeperName.Text == "" && string.IsNullOrEmpty(txtKeeperSurname.Text))
            {
                MessageBox.Show("Please feel all the fields");
                return;
            }
            Keeper keeper = new Keeper()
            {

                Name = txtKeeperName.Text.Trim(),
                SurName = txtKeeperSurname.Text.Trim()
            };
            db.Keepers.Add(keeper);
            db.SaveChanges();
            MessageBox.Show("Keeper successfully added");
            txtKeeperName.Text = "";
            txtKeeperSurname.Text = "";
        }
        private void EditKeeper()
        {
            keeper.Name = txtKeeperName.Text.Trim();
            keeper.SurName = txtKeeperSurname.Text.Trim();     
            db.SaveChanges();
            MessageBox.Show("Keeper successfully updated");
            Close();
        }
    }
}
