using Core.Uslugi;
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
    public partial class TiresHistory : Form
    {
       
        public TiresHistory()
        {
            InitializeComponent();
        }
      
        private void btnCofnij_Click(object sender, EventArgs e)
        {
            Tires tires = new Tires();
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
    }
}
