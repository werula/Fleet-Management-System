using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Uslugi;
using Domena.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

using FuelDb = Domena.Models.Fuel;

namespace DesktopApp
{
    public partial class Fuel : Form
    {
        public static Fuel CurrentContext { get; set; }
        public static FuelHistory HistoryContext { get; set; }

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

        private FuelService fuelService = null;
        public virtual FuelService FuelService
        {
            get
            {
                if (fuelService == null)
                {
                    fuelService = new FuelService();
                }

                return fuelService;
            }
        }

        public Fuel()
        {
            InitializeComponent();

            this.LoadVehicles();
        }

        private void LoadVehicles()
        {
            // wyczyścić obecne dane 
            comboBox1.DataSource = null;
            // pobrać nowe dane
            var newData = VehicleService.GetArray();

            // ustawić źródło DataGridView
            comboBox1.DataSource = newData.Select(x => $"{x.Brand} - {x.Model} - {x.PlateNumber}").ToArray();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FuelDb fuel = new FuelDb();

            fuel.Quantity = txtQuantity.Text;
            fuel.Amount = txtAmount.Text;
            fuel.OdometerReading = txtOdometer.Text;
            fuel.FillDate = dTPFillDate.Value.ToUniversalTime();


            var result = FuelService.Create(fuel);

            if (result is null)
            {
                MessageBox.Show("Dodawanie nie powiodło się!");
            }

            MessageBox.Show("Pomyslnie dodano!");
          
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            VehicleMenu menu = new VehicleMenu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HistoryContext = new FuelHistory();
            //HistoryContext.Show();
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = comboBox1.SelectedItem.ToString();

           

            //Vehicle weSearch = new Vehicle();
            //HistoryContext.ViewHistoryOf(weSearch);
        }
    }
}
