namespace DesktopApp.Models.NestedForms
{
    partial class PickDriver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listRowDriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listRowDriverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dGVDrivers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listRowDriverBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listRowDriverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRowDriverBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRowDriverBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // listRowDriverBindingSource
            // 
            this.listRowDriverBindingSource.DataSource = typeof(DesktopApp.Models.ListRowDriver);
            // 
            // listRowDriverBindingSource1
            // 
            this.listRowDriverBindingSource1.DataSource = typeof(DesktopApp.Models.ListRowDriver);
            // 
            // dGVDrivers
            // 
            this.dGVDrivers.AllowUserToAddRows = false;
            this.dGVDrivers.AllowUserToDeleteRows = false;
            this.dGVDrivers.AutoGenerateColumns = false;
            this.dGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.licensesDataGridViewTextBoxColumn});
            this.dGVDrivers.DataSource = this.listRowDriverBindingSource2;
            this.dGVDrivers.Location = new System.Drawing.Point(-5, -4);
            this.dGVDrivers.Name = "dGVDrivers";
            this.dGVDrivers.ReadOnly = true;
            this.dGVDrivers.RowHeadersWidth = 62;
            this.dGVDrivers.RowTemplate.Height = 33;
            this.dGVDrivers.Size = new System.Drawing.Size(665, 483);
            this.dGVDrivers.TabIndex = 0;
            this.dGVDrivers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDrivers_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // licensesDataGridViewTextBoxColumn
            // 
            this.licensesDataGridViewTextBoxColumn.DataPropertyName = "Licenses";
            this.licensesDataGridViewTextBoxColumn.HeaderText = "Licenses";
            this.licensesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.licensesDataGridViewTextBoxColumn.Name = "licensesDataGridViewTextBoxColumn";
            this.licensesDataGridViewTextBoxColumn.ReadOnly = true;
            this.licensesDataGridViewTextBoxColumn.Width = 150;
            // 
            // listRowDriverBindingSource2
            // 
            this.listRowDriverBindingSource2.DataSource = typeof(DesktopApp.Models.ListRowDriver);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(2, 494);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(524, 31);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnPick
            // 
            this.btnPick.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPick.Location = new System.Drawing.Point(532, 494);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(128, 31);
            this.btnPick.TabIndex = 2;
            this.btnPick.Text = "Wybierz";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // PickDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 527);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dGVDrivers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PickDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickDriver";
            ((System.ComponentModel.ISupportInitialize)(this.listRowDriverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRowDriverBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRowDriverBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private BindingSource listRowDriverBindingSource;
        private BindingSource listRowDriverBindingSource1;
        private DataGridView dGVDrivers;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licensesDataGridViewTextBoxColumn;
        private BindingSource listRowDriverBindingSource2;
        private TextBox txtSearch;
        private Button btnPick;
    }
}