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

using TiresDb = Domena.Models.Tire;

namespace DesktopApp
{
    public partial class Tires : Form
    {
        public static Tires CurrentContext { get; set; }
        public static TiresHistory HistoryContext { get; set; }

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

        private TiresService tiresService = null;
        public virtual TiresService TiresService
        {
            get
            {
                if (tiresService == null)
                {
                    tiresService = new TiresService();
                }

                return tiresService;
            }
        }
        public Tires()
        {
            InitializeComponent();
            this.LoadVehicles();
        }
        private void LoadVehicles()
        {
            // wyczyścić obecne dane 
            cBVehicle.DataSource = null;
            // pobrać nowe dane
            var newData = VehicleService.GetArray();

            // ustawić źródło DataGridView
            cBVehicle.DataSource = newData.Select(x => $"{x.Brand} - {x.Model} - {x.PlateNumber}").ToArray();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            VehicleMenu menu = new VehicleMenu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiresHistory tires = new TiresHistory();
            tires.Show();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            TiresDb tire = new TiresDb();

            tire.Vendor = txtVendor.Text;
            tire.TiresNumber = txtTiresNo.Text;
            tire.Quantity = txtQuantity.Text;
            tire.PurchaseDate = dTPDatePurchase.Value.ToUniversalTime();
            

            var result = TiresService.Create(tire);

            if (result is null)
            {
                MessageBox.Show("Dodawanie nie powiodło się!");
            }

            MessageBox.Show("Pomyslnie dodano!");


        }
    }
}
