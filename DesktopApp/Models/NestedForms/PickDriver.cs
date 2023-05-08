using Core.Uslugi;
using Domena.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Models.NestedForms
{
    public interface IDataPickable<T>
    {
        T Get(object config);
    }


    public partial class PickDriver : Form, IDataPickable<Driver>
    {

        private DriverService driverService = null;
        public virtual DriverService DriverService
        {
            get
            {
                if (driverService == null)
                {
                    driverService = new DriverService();
                }

                return driverService;
            }
        }

        public static PickDriver CurrentContext { get; set; }
        public static Vehicle VehiclesForm { get; set; }

        public Driver Selected { get; set; }

        //public PickDriver()
        //{
        //    InitializeComponent();
        //    CurrentContext = this;

        //    this.LoadCurrentData();

        //    string idColumnName = dGVDrivers.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Name;
        //    dGVDrivers.Columns[idColumnName].Visible = false;
        //}

        public PickDriver(Vehicle vehiclesForms)
        {
            InitializeComponent();
            CurrentContext = this;
            VehiclesForm = vehiclesForms;

            this.LoadCurrentData();

            string idColumnName = dGVDrivers.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Name;
            dGVDrivers.Columns[idColumnName].Visible = false;

        }

        public Driver Get(object config)
        {
            throw new NotImplementedException();
        }
        private void LoadCurrentData(IEnumerable<ListRowDriver>? toInject = null)
        {
            this.CleanData();

            IEnumerable<ListRowDriver> data = new List<ListRowDriver>();
            if (toInject != null)
            {
                data = toInject;
            }
            else
            {
                // pobrać nowe dane
                var fetched = DriverService.GetArray();
                var drivers = fetched.Select(x => new ListRowDriver(x)).OrderBy(x => x.Lastname).ToList();
                data = drivers;
            }

            // ustawić źródło DataGridView
            var toPass = data.ToList();
            dGVDrivers.DataSource = toPass;
        }

        private void CleanData()
        {
            // wyczyścić obecne dane 
            dGVDrivers.DataSource = null;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            // string searchValue = txtSearch.Text + e.KeyData;
            string searchValue = txtSearch.Text;

            var searchResult = DriverService.Search(searchValue);

            if(searchResult != null && searchResult.Count() > 0)
            {
                var mapped = searchResult.Select(x => new ListRowDriver(x)).ToList();
                this.LoadCurrentData(mapped);
                return;
            }

            this.CleanData();
        }

        private void dGVDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dGVDrivers.Rows[e.RowIndex].DataBoundItem as ListRowDriver;

            var driverId = selectedRow.Id;


            var driver = DriverService.GetSingle(driverId);

            if (driver is null)
            {
                // jeżeli nei został to wyświetlamy błąd
                MessageBox.Show("Nie odnaleziono rekordu o Id " + driverId);
                return;
            }

            Selected = driver;
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if(Selected is null)
            {
                MessageBox.Show("Nie wybrano kierowcy!");
                return;
            }

            VehiclesForm.FetchDriver(this.Selected);
            VehiclesForm.Focus();
            this.Selected = null;
            this.Close();
        }
    }

}
