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

using FuelForm = DesktopApp.Fuel;



namespace DesktopApp
{
    public partial class FuelHistory : Form
    {
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

        public static FuelHistory CurrentContext { get; set; }
        public static FuelForm FuelForm { get; set; }

        public Vehicle Selected { get; set; }

        public FuelHistory(FuelForm fuelForm)
        {
            CurrentContext = this;
            FuelForm = fuelForm;
            InitializeComponent();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.Show();
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

       // public void ViewHistoryOf(Vehicle vehicle)
        //{
         //   // Debug.WriteLin
        //}
       
    }
}
