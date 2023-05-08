using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Uslugi;
using DesktopApp.Models;
using Domena.Models;

namespace DesktopApp
{
    public partial class List : Form
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

        public List()
        {
            InitializeComponent();

            this.LoadCurrentData();

            //Debug.WriteLine(dGVDriver.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Name);
            dGVDriver.Columns["idDataGridViewTextBoxColumn"].Visible = false;
        }

        private void dGVDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dGVDriver.Rows[e.RowIndex].DataBoundItem as Driver;

            var driverId = selectedRow.Id;


            var driver = DriverService.GetSingle(driverId);

            if (driver is null)
            {
                // jeżeli nei został to wyświetlamy błąd
                MessageBox.Show("Nie odnaleziono rekordu o Id " + driverId);
                return;
            }

            if(driver.License != null)
            {
                if (driver.License.CatB.HasValue)
                {
                    cBKatB.Checked = driver.License.CatB.Value;
                }

                if (driver.License.CatC.HasValue)
                {
                    cBKatC.Checked = driver.License.CatC.Value;
                }
            }


            txtAddress.Text = selectedRow.Address;
            txtEmail.Text = selectedRow.Email;
            txtName.Text = selectedRow.Name;    
            txtPhone.Text = selectedRow.Phone;
            txtSurname.Text = selectedRow.Surname;
            txtId.Text = selectedRow.Id.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtId.Text.Length <= 0) {
                return;
            }

            // odszukać obiekt po Id
            int Id = Int32.Parse(txtId.Text);
            Driver toUpdate = DriverService.GetSingle(Id);


            // sprawdzić czy odnalazł obiekt
            if (toUpdate is null)
            {
                // jeżeli nei został to wyświetlamy błąd
                MessageBox.Show("Nie odnaleziono rekordu o Id " + Id);
                return;
            }
            // nadpisać zmiany
            toUpdate.Address = txtAddress.Text;
            toUpdate.Email = txtEmail.Text;
            toUpdate.Name = txtName.Text;
            toUpdate.Phone = txtPhone.Text;
            toUpdate.Surname = txtSurname.Text;


            if(toUpdate.License != null)
            {
                toUpdate.License.CatB = cBKatB.Checked;
                toUpdate.License.CatC = cBKatC.Checked;
            }
            else
            {
                toUpdate.License = new Domena.Models.License()
                {
                    CatB = cBKatB.Checked,
                    CatC = cBKatC.Checked,
                };
            }
            

            // wywołać aktualizacje
            Driver driver = DriverService.Update(toUpdate);

            this.LoadCurrentData();
        }

        private void LoadCurrentData()
        {
            // wyczyścić obecne dane 
            dGVDriver.DataSource = null;
            // pobrać nowe dane
            var newData = DriverService.GetArray();

            // ustawić źródło DataGridView
            dGVDriver.DataSource = newData;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();

            driver.Name = txtName.Text;
            driver.Surname = txtSurname.Text;
            driver.Phone = txtPhone.Text;
            driver.Address = txtAddress.Text;
            driver.Email = txtEmail.Text;

            driver.License = new Domena.Models.License()
            {
                CatB = cBKatB.Checked,
                CatC = cBKatC.Checked,
            };

            var result = DriverService.Create(driver);
            
            if(result is null){
                MessageBox.Show("Dodawanie nie powiodło się!");
            }
            
            MessageBox.Show("Pomyslnie dodano kierowce!");
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cBKatB.Checked = false;
            cBKatC.Checked = false;

            this.LoadCurrentData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(txtId.Text);
            MessageBox.Show($"Czy na pewno chcesz usunąć kierowce: { id} ?", "Potwierdz", MessageBoxButtons.YesNo);
            var result = DriverService.Delete(id);

            if (result is false)
            {
                MessageBox.Show("Usuwanie nie powiodło się!");
            }
            MessageBox.Show("Pomyslnie usunieto!");

            this.LoadCurrentData();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            AdminTable admin = new AdminTable();
            admin.Show();
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
    }
}
