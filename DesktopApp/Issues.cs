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

using IssueDb = Domena.Models.Issue;


namespace DesktopApp
{
    public partial class Issues : Form
    {
        public static Issues CurrentContext { get; set; }
        public static IssuesHistory HistoryContext { get; set; }

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

        private IssueService issueService = null;
        public virtual IssueService IssueService
        {
            get
            {
                if (issueService == null)
                {
                    issueService = new IssueService();
                }

                return issueService;
            }
        }
        public Issues()
        {
            InitializeComponent();
            this.LoadVehicles();
        }

        private void LoadVehicles()
        {
            // wyczyścić obecne dane 
            comboBox1.DataSource = null;
            // pobrać nowe dane
            var newData = VehicleService.GetArray();

            // ustawić źródło DataGridView
            comboBox1.DataSource = newData.Select(x => $"{x.Brand} - {x.Model} - {x.PlateNumber}").ToArray();
        }
        private void btnCofnij_Click(object sender, EventArgs e)
        {
            VehicleMenu menu = new VehicleMenu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IssuesHistory history = new IssuesHistory();
            history.Show();
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
            IssueDb issue = new IssueDb();

           
            issue.Problem = txtIssue.Text;
            issue.Description = txtDescription.Text;
            issue.DueDate = dTPDueData.Value.ToUniversalTime();


            var result = IssueService.Create(issue);

            if (result is null)
            {
                MessageBox.Show("Dodawanie nie powiodło się!");
            }

            MessageBox.Show("Pomyslnie dodano!");

        }
    }
}
