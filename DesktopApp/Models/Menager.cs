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
using DesktopApp.Models;
using System.Diagnostics;

namespace DesktopApp.Models
{
    public partial class Menager : Form
    {
        private UserService managerService = null;

        public virtual UserService ManagerService
        {
            get
            {
                if (managerService == null)
                {
                    managerService = new UserService();
                }

                return managerService;
            }
        }
        public Menager()
        {
            InitializeComponent();
            this.LoadCurrentData();

            dGVManager.Columns["idDataGridViewTextBoxColumn1"].Visible = false;
        }

        private void LoadCurrentData()
        {
            dGVManager.DataSource = null;
            var newData = ManagerService.GetArray();
            dGVManager.DataSource = newData;



            // typy użytkowników
            var userTypes = ManagerService.GetUserTypes();

            foreach (var type in userTypes)
            {
                lstUserTypes.Items.Add(type.Name);
            }

        }

  

        private void dGVManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dGVManager.Rows[e.RowIndex].DataBoundItem as User;

            var userId = selectedRow.Id;


            var user = ManagerService.GetSingle(userId);

            if (user is null)
            {
                // jeżeli nei został to wyświetlamy błąd
                MessageBox.Show("Nie odnaleziono rekordu o Id " + userId);
                return;
            }

            txtAddress.Text = selectedRow.Address;
            txtEmail.Text = selectedRow.Email;
            txtName.Text = selectedRow.Name;
            txtPhone.Text = selectedRow.Phone;
            txtSurname.Text = selectedRow.Surname;
            txtPostcode.Text = selectedRow.Postcode;
            txtId.Text = selectedRow.Id.ToString();

            var fetchedRow = ManagerService.GetSingle(selectedRow.Id);

            int selectedIndex = 0;
            for (int i = 0; i < lstUserTypes.Items.Count; i++)
            {
                var item = lstUserTypes.Items[i];

                if(item.ToString().ToUpper() == fetchedRow.UserType.Name.ToUpper())
                {
                    selectedIndex = i;
                    continue;
                }
            }

            lstUserTypes.SetSelected(selectedIndex, true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lstUserTypes.SelectedItem is null)
            {
                MessageBox.Show("Wybierz rodzaj użytkownika!");
                return;
            }

          
            User manager = new User();

            manager.Name = txtName.Text;
            manager.Surname = txtSurname.Text;
            manager.Phone = txtPhone.Text;
            manager.Address = txtAddress.Text;
            manager.Postcode = txtPostcode.Text;
            manager.Email = txtEmail.Text;
            manager.Password = txtPassword.Text;

            string userTypeName = lstUserTypes.SelectedItem.ToString();
            var getResult = ManagerService.GetuserTypeByName(userTypeName);

            if(getResult is null)
            {
                // obsługa błędu
                MessageBox.Show($"Nie odnaleziono typu użytkownika o nazwie {userTypeName}");
                return;
            }

            manager.UserTypeId = getResult.Id;

            var result = ManagerService.Create(manager);

            if (result is null)
            {
                MessageBox.Show("Dodawanie nie powiodło się!");
            }

            MessageBox.Show("Pomyslnie dodano!");
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPostcode.Clear();
            txtEmail.Clear();
            

            this.LoadCurrentData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length <= 0)
            {
                return;
            }
            int Id = Int32.Parse(txtId.Text);
            User toUpdate = ManagerService.GetSingle(Id);

            // Pobrać dane z formularza oraz na podstawie wybranego typu użytkownika, pobrać rekord Typu użytkownika z bazy danych

           

            // zwalidować dane
            if (toUpdate is null)
            {
                MessageBox.Show($"Nie odnaleziono rekordu o Id {Id}");
                return;
            }

            if (lstUserTypes.SelectedItem is null)
            {
                MessageBox.Show("Wybierz rodzaj użytkownika!");
                return;
            }
           
            // pobrać rekord z bazy danych na podstawi Id z DataGridView


            // nadpisać dokonane zmiane na obiekcie
            toUpdate.Name = txtName.Text;
            toUpdate.Surname = txtSurname.Text;
            toUpdate.Phone = txtPhone.Text;
            toUpdate.Address = txtAddress.Text;
            toUpdate.Postcode = txtPostcode.Text;
            toUpdate.Email = txtEmail.Text;

            // przekazać obiekt do aktualizacji
            User manager = ManagerService.Update(toUpdate);
  

            // odświeżyć obecne dane w fformularzu
            this.LoadCurrentData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtId.Text.Length <= 0)
            {
                return;
            }
            int id = Int32.Parse(txtId.Text);
            MessageBox.Show("Czy na pewno chcesz usunąć?", "Potwierdz", MessageBoxButtons.YesNo);
            var result = ManagerService.Delete(id);

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
