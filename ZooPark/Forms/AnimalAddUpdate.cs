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
    public partial class AnimalAddUpdate : Form
    {
        private readonly ApplicationDbContext db;
        private readonly Animal animal;

        public AnimalAddUpdate(ApplicationDbContext db)
        {
            this.db = db;
            InitializeComponent();
            LoadData();
        }
        public AnimalAddUpdate(ApplicationDbContext db, Animal animal)
        {
            this.db = db;
            this.animal = animal;
            InitializeComponent();
            btnAnimalAddUpdate.Text = "Update";
            LoadData();
            GetInformation();
        }
        private void LoadData()
        {
            clbKeepers.DataSource = db.Keepers.OrderBy(x => x.Name).ToList();
            clbKeepers.DisplayMember = "Name";
            cmbFavFood.DataSource = db.Food.ToList();
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));
        }
        private void DataClean()
        {
            txtAnimalName.Text = "";
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            nudMass.Value = 0.0m;
            txtSpecies.Text = "";
            cmbFavFood.SelectedIndex = -1;

        }
        private void GetInformation()
        {
            txtAnimalName.Text = animal.Name;
            cmbGender.SelectedIndex = (int)animal.Gender;
            cbHaveOwner.Checked = animal.HavingOwner;
            dtpDOB.Value = animal.DOB.Value;
            nudMass.Value = animal.Mass;
            txtSpecies.Text = animal.Species;
            for (int i = 0; i < clbKeepers.Items.Count; i++)
            {
                Keeper keeper = (Keeper)clbKeepers.Items[i];
                if (animal.Keepers.Contains(keeper))
                    clbKeepers.SetItemChecked(i, true);
            }
            Food food = (Food)animal.Food;
            cmbFavFood.SelectedItem = food;
        }
        private void btnAnimalAddUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnimalName.Text) && string.IsNullOrEmpty(txtSpecies.Text) && nudMass.Value > 0 && clbKeepers.CheckedItems.Count == 0 && cmbFavFood.SelectedIndex != -1)
            {
                return;
            }
            if (btnAnimalAddUpdate.Text == "Update")
            {
                EditAnimal();

            }
            if (btnAnimalAddUpdate.Text == "Add")
            {
                NewAnimal();
            }
        }

        private void EditAnimal()
        {
            animal.Name = txtAnimalName.Text.Trim();
            animal.Gender = (Gender)cmbGender.SelectedIndex;
            animal.HavingOwner = cbHaveOwner.Checked;
            animal.DOB = dtpDOB.Value;
            animal.Mass = nudMass.Value;
            animal.Species = txtSpecies.Text;
            animal.Keepers.Clear();
            foreach (Keeper keeper in clbKeepers.CheckedItems)
                animal.Keepers.Add(keeper);
            animal.Food =(Food)cmbFavFood.SelectedItem;
            db.SaveChanges();
            MessageBox.Show("Animal is succesfully edited");
        }

        private void NewAnimal()
        {
            Food food = (Food)cmbFavFood.SelectedItem;
            Animal newAnimal = new Animal();
            newAnimal.Name = txtAnimalName.Text.Trim();
            newAnimal.Gender = (Gender)cmbGender.SelectedIndex;
            newAnimal.HavingOwner = cbHaveOwner.Checked;
            newAnimal.DOB = dtpDOB.Value.Date;
            newAnimal.Mass = nudMass.Value;
            newAnimal.Species = txtSpecies.Text;
            foreach (Keeper keeper in clbKeepers.CheckedItems)
                newAnimal.Keepers.Add(keeper);
            newAnimal.Food = food;
            db.Animals.Add(newAnimal);
            db.SaveChanges();
            MessageBox.Show("Animal is succesfully added");
            DataClean();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
