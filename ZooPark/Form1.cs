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
using ZooPark.Forms;

namespace ZooPark
{
    public partial class Form1 : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        KeeperAddUpdate keeperAdd;
        FoodAddUpdate foodAdd;
        AnimalAddUpdate animalAdd;
        Keeper keeper;

        public Form1()
        {
            //SeedData();
            InitializeComponent();
            LoadControls();
            LoadData();
            LoadAnimals();
        }
        private void LoadControls()
        {
            cmbKeeper.Items.Clear();
            List<string> edits = new List<string>() { "Keeper", "Food", "Animal" };
            cmbEditSelection.DataSource = null;
            cmbEditSelection.DataSource = edits;
            cmbEditSelection.SelectedIndex = -1;
        }
        private void SeedData()
        {
            Keeper keeper = db.Keepers.FirstOrDefault(x => x.Id == 1);
            Animal animal = new Animal()
            {
                Name = "Lucy",
                Gender = Gender.Female,
                HavingOwner = true,
                DOB = new DateTime(2019, 2, 12),
                Mass = 3.5m,
                Species = "Cat",
                FoodId = 1
            };
            animal.Keepers.Add(keeper);
            db.Animals.Add(animal);

            db.Animals.Add(new Animal() { Name = "Rex", Gender = Gender.Male, HavingOwner = false, DOB = new DateTime(2021, 2, 12), Mass = 5.5m, Species = "Dog" });
            db.SaveChanges();
        }
        private void LoadData()
        {             
           //
            var keeperList = db.Keepers.ToList();
            keeperList.Insert(0, new Keeper()
            {
                Name = "-Animals with no Keepers -",
                SurName = "Hayvanlar",
                Animals = db.Animals.Where(k => k.Keepers.Count == 0).ToList()
            });
            cmbKeeper.DataSource = keeperList;
            cmbKeeper.DisplayMember = "Name";
            cmbKeeper.SelectedIndex = -1;

            //
            dgvAnimals.DataSource = null;
            LoadAnimals();
        }
        private void LoadAnimals()
        {
            dgvAnimals.DataSource = null;

            if (cmbKeeper.SelectedIndex == -1) return;

            Keeper keeper = (Keeper)cmbKeeper.SelectedItem;
            dgvAnimals.DataSource = keeper.Animals.Select(x => new
            {
                x.Id,
                AnimalName = x.Name,
                x.Gender,
                x.Mass,
                x.HavingOwner,
                x.Species,
                x.DOB,
                FoodName = x.Food != null ? x.Food.Name : "",
                Keepers = x.Keepers != null ? string.Join(", ", x.Keepers.Select(b => b.Name)) : ""
            }).ToList();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadAnimals();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count == 0) return;

            int Id = (int)dgvAnimals.SelectedRows[0].Cells[0].Value;

            Animal deleteAnimal = db.Animals.Find(Id);
            db.Animals.Remove(deleteAnimal);
            db.SaveChanges();
            LoadData();
        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbEditSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select edited field");
                return;
            }
            if (cmbEditSelection.SelectedIndex == 0)
            {
                keeperAdd = new KeeperAddUpdate(db);
                keeperAdd.ShowDialog();
                LoadData();           
            }
            if (cmbEditSelection.SelectedIndex == 1)
            {
                Food food = new Food();
                foodAdd = new FoodAddUpdate(db);
                foodAdd.ShowDialog();
                LoadData();               
            }
            if (cmbEditSelection.SelectedIndex == 2)
            {
                animalAdd = new AnimalAddUpdate(db);
                animalAdd.ShowDialog();
                LoadData();
                LoadAnimals();
            }
        }
        private void dgvAnimals_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count == 0) return;
            int Id = (int)dgvAnimals.SelectedRows[0].Cells[0].Value;
            Animal animal = db.Animals.Find(Id);
            AnimalAddUpdate animalAddUpdate = new AnimalAddUpdate(db, animal);
            animalAddUpdate.ShowDialog();
        }
        private void cmbBakicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAnimals();
        }      
        private void btnKeeperUpdate_Click(object sender, EventArgs e)
        {
            if (cmbKeeper.SelectedIndex == -1)
            {
                MessageBox.Show("Please select edited field");
                return;
            }
            if (cmbKeeper.SelectedIndex > -1)
            {
                keeper = new Keeper();
                keeper = (Keeper)cmbKeeper.SelectedItem;
                keeperAdd = new KeeperAddUpdate(keeper, db);
                keeperAdd.ShowDialog();
                LoadData();
            }
        }
        private void btnKeeperDelete_Click(object sender, EventArgs e)
        {
            if (cmbKeeper.SelectedIndex < 1)
            {
                return;
            }
            else
            {
                Keeper keeper = (Keeper)cmbKeeper.SelectedItem;
                db.Keepers.Remove(keeper);
                db.SaveChanges();
                LoadData();
            }
        }
        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            if (cmbFood.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Food");
                return;
            }
            Food food = (Food)cmbFood.SelectedItem;
            db.Food.Remove(food);
            db.SaveChanges();
            LoadData();
        }
        private void btnFoodUpdate_Click(object sender, EventArgs e)
        {
            if (cmbKeeper.SelectedIndex == -1)
            {
                MessageBox.Show("Please select edited field");
                return;
            }     
            //TODO update yapilacak

            //    food = new Food();
            //    foodAdd = new FoodAddUpdate(food,db);
            //    foodAdd.ShowDialog();
            //    keeperAdd.ShowDialog();
            //    LoadData();         
        }
    }
}
