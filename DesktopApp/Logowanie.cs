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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zakończyć działanie?", "Zamknij program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Wprowadź login i hasło!");
            }
            else if(txtLogin.Text == "Admin" && txtPassword.Text == "Admin")
            {
                AdminTable admintable = new AdminTable();
                admintable.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Zła nazwa użytownika lub hasło!");
            }
        }
    }
}
