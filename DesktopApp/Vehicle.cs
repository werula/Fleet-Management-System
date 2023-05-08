using Core.Uslugi;
using DesktopApp.Models.NestedForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domena.Models;

using VehicleDb = Domena.Models.Vehicle;

namespace DesktopApp
{
    public partial class Vehicle : Form
    {
        public static Vehicle CurrentContext { get; set; }

        private VehicleService vehicleService = null;
        public virtual VehicleService VehicleService
        {
            get
            {
                if (vehicleService == null)
                {
                    vehicleService = new VehicleService();
                }

                return vehicleService;
            }
        }


        private DriversVehiclesReferenceServices driversVehiclesReferenceServices = null;
        public virtual DriversVehiclesReferenceServices DriversVehiclesReferenceServices
        {
            get
            {
                if (driversVehiclesReferenceServices == null)
                {
                    driversVehiclesReferenceServices = new DriversVehiclesReferenceServices();
                }

                return driversVehiclesReferenceServices;
            }
        }


        public Driver Fetched { get; set; }

        public Vehicle()
        {
            InitializeComponent();

            CurrentContext = this;

            string idColumnName = dataGridView1.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Name;
            dataGridView1.Columns[idColumnName].Visible = false;
        }

        private void LoadCurrentData()
        {
            // wyczyścić obecne dane 
            dataGridView1.DataSource = null;

            // pobrać nowe dane
            var vehicles = VehicleService.GetArray();

            // ustawić źródło DataGridView
            dataGridView1.DataSource = vehicles;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            VehicleDb vehicle = new VehicleDb();

            vehicle.PlateNumber = txtPlate.Text;
            vehicle.Brand = txtBrand.Text;
            vehicle.Model = txtModel.Text;
            vehicle.Year = txtYear.Text;
            vehicle.Color = txtColor.Text;
            vehicle.NextReview = dTPReview.Value.ToUniversalTime();
            vehicle.NextInsurance = dTPInsurance.Value.ToUniversalTime();

            // TODO: zaimplementować wybó typu pojazdu z listy
            vehicle.TypeId = 1;

            var result = VehicleService.Create(vehicle);

            if (result is null)
            {
                MessageBox.Show("Dodawanie nie powiodło się!");
                return;
            }

            if (txtSelectedDriverId.Text != null && txtSelectedDriverId.Text.Length > 0)
            {
                int? parsedId = Int32.Parse(txtSelectedDriverId.Text);
                if(parsedId is null)
                {
                    MessageBox.Show("Błąd parsowania Id");
                    return;
                }

                var reference = new DriverVehicleAssingment() {
                    VehicleId = result.Id,
                    DriverId = parsedId
                };

                DriversVehiclesReferenceServices.AddReference(reference);
            }

            MessageBox.Show("Pomyslnie dodano!");

            this.LoadCurrentData();
        }

        private void btnWybierzKierowce_Click(object sender, EventArgs e)
        {
            PickDriver pickDriverForm = new PickDriver(this);
            pickDriverForm.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            MessageBox.Show($"Czy na pewno chcesz usunąć kierowce: { id} ?", "Potwierdz", MessageBoxButtons.YesNo);
            var result = VehicleService.Delete(id);

            if (result is false)
            {
                MessageBox.Show("Usuwanie nie powiodło się!");
            }
            MessageBox.Show("Pomyslnie usunieto!");

            this.LoadCurrentData();
        }

        private void btnAktualizuj_Click(object sender, EventArgs e)
        {
            int Id = Int32.Parse(txtId.Text);

            if (txtId.Text.Length <= 0)
            {
                return;
            }

            
            // var test = VehicleService.GetSingle
            VehicleDb toUpdate = VehicleService.GetSingle(Id);
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            VehicleMenu menu = new VehicleMenu();
            menu.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zakończyć działanie?", "Zamknij program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void FetchDriver(Driver toFetch)
        {
            this.Fetched = toFetch;

            txtSelectedDriverId.Text = this.Fetched.Id.ToString();

            StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(this.Fetched.Name);
                stringBuilder.Append(" ");
                stringBuilder.Append(this.Fetched.Surname);

            txtKierowca.Text = stringBuilder.ToString();
        }
    }
    
}
