using Core.Uslugi;
using Domena.Models;
using System.Diagnostics;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        private DriverService driverService = null;
        public virtual DriverService DriverService { get
            {
                if(driverService == null)
                {
                    driverService = new DriverService();
                }

                return driverService;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();


            driver.Name = txtName.Text;
            driver.Surname = txtSurname.Text;
            driver.Phone = txtPhone.Text;
            driver.Address = txtAddress.Text;
            driver.Email = txtEmail.Text;

            DriverService.Create(driver);
            MessageBox.Show("Pomyslnie dodano kierowce!");
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

        }

        private void btnLoadById_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            var driver = DriverService.GetSingle(id);

            if(driver == null)
            {
                MessageBox.Show($"Nie odnaleziono kierowcy o Id: {id}" );
                return;
            }

            txtName.Text = driver.Name;
            txtSurname.Text = driver.Surname;
            txtPhone.Text = driver.Phone;
            txtAddress.Text = driver.Address;
            txtEmail.Text  = driver.Email;
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            
            int id = Int32.Parse(txtId.Text);
            MessageBox.Show($"Czy na pewno chcesz usun¹æ kierowce: { id} ?", "Potwierdz", MessageBoxButtons.YesNo);
            var driver = DriverService.Delete(id);
            MessageBox.Show("Pomyslnie usunieto!");
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            // Mieæ obiekt
            Driver toUpdate = DriverService.GetSingle(id);

            if(toUpdate is null)
            {
                // je¿eli nei zosta³ to wyœwietlamy b³¹d
                MessageBox.Show("Nie odnaleziono rekordu o Id "+id);
                return;
            }

            // Wprowadziæ zmiany
            toUpdate.Name = txtName.Text;
            toUpdate.Surname = txtSurname.Text;
            toUpdate.Phone = txtPhone.Text;
            toUpdate.Address = txtAddress.Text;
            toUpdate.Email = txtEmail.Text;

            // Przekazaæ do akutalizacji
            Driver driver = DriverService.Update(toUpdate);

            Debug.WriteLine("");
        }
    }//aktualizowanie 
}