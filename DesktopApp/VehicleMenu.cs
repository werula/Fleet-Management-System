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
    public partial class VehicleMenu : Form
    {
        public VehicleMenu()
        {
            InitializeComponent();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            AdminTable back = new AdminTable();
            back.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Show();
            this.Hide();
        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.Show();
            this.Hide();
        }

        private void btnTires_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.Show();
            this.Hide();
        }

        private void btnProblem_Click(object sender, EventArgs e)
        {
            Issues issue = new Issues();
            issue.Show();
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
