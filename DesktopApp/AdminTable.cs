using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApp
{
    public partial class AdminTable : Form
    {
        public AdminTable()
        {
            InitializeComponent();
        }

        private void btnZakończ_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zakończyć działanie?", "Zamknij program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyloguj się", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Logowanie logowanie = new Logowanie();
                logowanie.Show();
                this.Hide();
            }
            
        }

        private void btnKierowcy_Click(object sender, EventArgs e)
        {
            List drivers = new List();
            drivers.Show();
            this.Hide();
        }

        private void btnUżytkownicy_Click(object sender, EventArgs e)
        {
            Menager users = new Menager();
            users.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleMenu menu = new VehicleMenu();
            menu.Show();
            this.Hide();
        }
    }
}
