namespace DesktopApp
{
    partial class Vehicle
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
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.dTPReview = new System.Windows.Forms.DateTimePicker();
            this.dTPInsurance = new System.Windows.Forms.DateTimePicker();
            this.vehicleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnWybierzKierowce = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKierowca = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSelectedDriverId = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextReviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextInsuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(Domena.Models.Vehicle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer rejestracyjny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kolor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(633, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Następny przegląd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(633, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Następne ubezpieczenie";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(281, 157);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(300, 31);
            this.txtPlate.TabIndex = 6;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(281, 219);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(300, 31);
            this.txtBrand.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(281, 344);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(300, 31);
            this.txtYear.TabIndex = 8;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(281, 412);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(300, 31);
            this.txtColor.TabIndex = 9;
            // 
            // dTPReview
            // 
            this.dTPReview.Location = new System.Drawing.Point(906, 157);
            this.dTPReview.Name = "dTPReview";
            this.dTPReview.Size = new System.Drawing.Size(300, 31);
            this.dTPReview.TabIndex = 10;
            // 
            // dTPInsurance
            // 
            this.dTPInsurance.Location = new System.Drawing.Point(906, 227);
            this.dTPInsurance.Name = "dTPInsurance";
            this.dTPInsurance.Size = new System.Drawing.Size(300, 31);
            this.dTPInsurance.TabIndex = 11;
            // 
            // vehicleBindingSource1
            // 
            this.vehicleBindingSource1.DataSource = typeof(Domena.Models.Vehicle);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsun.Location = new System.Drawing.Point(1038, 369);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(168, 74);
            this.btnUsun.TabIndex = 12;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAktualizuj.Location = new System.Drawing.Point(837, 369);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(168, 74);
            this.btnAktualizuj.TabIndex = 13;
            this.btnAktualizuj.Text = "Aktualizuj";
            this.btnAktualizuj.UseVisualStyleBackColor = true;
            this.btnAktualizuj.Click += new System.EventHandler(this.btnAktualizuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.Location = new System.Drawing.Point(633, 369);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(168, 74);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.plateNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.typeIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.nextReviewDataGridViewTextBoxColumn,
            this.nextInsuranceDataGridViewTextBoxColumn,
            this.driversDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 519);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 440);
            this.dataGridView1.TabIndex = 15;
            // 
            // vehicleBindingSource2
            // 
            this.vehicleBindingSource2.DataSource = typeof(Domena.Models.Vehicle);
            // 
            // btnWybierzKierowce
            // 
            this.btnWybierzKierowce.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWybierzKierowce.Location = new System.Drawing.Point(633, 283);
            this.btnWybierzKierowce.Name = "btnWybierzKierowce";
            this.btnWybierzKierowce.Size = new System.Drawing.Size(223, 34);
            this.btnWybierzKierowce.TabIndex = 16;
            this.btnWybierzKierowce.Text = "Wybierz kierowce";
            this.btnWybierzKierowce.UseVisualStyleBackColor = true;
            this.btnWybierzKierowce.Click += new System.EventHandler(this.btnWybierzKierowce_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(48, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(281, 283);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(300, 31);
            this.txtModel.TabIndex = 18;
            // 
            // txtKierowca
            // 
            this.txtKierowca.Enabled = false;
            this.txtKierowca.Location = new System.Drawing.Point(906, 285);
            this.txtKierowca.Name = "txtKierowca";
            this.txtKierowca.Size = new System.Drawing.Size(300, 31);
            this.txtKierowca.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1305, 156);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(8, 31);
            this.txtId.TabIndex = 20;
            this.txtId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(48, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(429, 38);
            this.label8.TabIndex = 21;
            this.label8.Text = "Informacje o samochodzie";
            // 
            // btnCofnij
            // 
            this.btnCofnij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofnij.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCofnij.ForeColor = System.Drawing.Color.Black;
            this.btnCofnij.Location = new System.Drawing.Point(12, 12);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(114, 37);
            this.btnCofnij.TabIndex = 25;
            this.btnCofnij.Text = "Cofnij";
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1255, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 37);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSelectedDriverId
            // 
            this.txtSelectedDriverId.Location = new System.Drawing.Point(1128, 80);
            this.txtSelectedDriverId.Name = "txtSelectedDriverId";
            this.txtSelectedDriverId.Size = new System.Drawing.Size(94, 31);
            this.txtSelectedDriverId.TabIndex = 53;
            this.txtSelectedDriverId.Visible = false;
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
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "Numer rejestracyjny";
            this.plateNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            this.plateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.plateNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn1.HeaderText = "Marka";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Rok";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // nextReviewDataGridViewTextBoxColumn
            // 
            this.nextReviewDataGridViewTextBoxColumn.DataPropertyName = "NextReview";
            this.nextReviewDataGridViewTextBoxColumn.HeaderText = "Data następnego przeglądu";
            this.nextReviewDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nextReviewDataGridViewTextBoxColumn.Name = "nextReviewDataGridViewTextBoxColumn";
            this.nextReviewDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextReviewDataGridViewTextBoxColumn.Width = 150;
            // 
            // nextInsuranceDataGridViewTextBoxColumn
            // 
            this.nextInsuranceDataGridViewTextBoxColumn.DataPropertyName = "NextInsurance";
            this.nextInsuranceDataGridViewTextBoxColumn.HeaderText = "Data końca ubezpieczenia";
            this.nextInsuranceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nextInsuranceDataGridViewTextBoxColumn.Name = "nextInsuranceDataGridViewTextBoxColumn";
            this.nextInsuranceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextInsuranceDataGridViewTextBoxColumn.Width = 150;
            // 
            // driversDataGridViewTextBoxColumn
            // 
            this.driversDataGridViewTextBoxColumn.DataPropertyName = "Drivers";
            this.driversDataGridViewTextBoxColumn.HeaderText = "Kierowca";
            this.driversDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.driversDataGridViewTextBoxColumn.Name = "driversDataGridViewTextBoxColumn";
            this.driversDataGridViewTextBoxColumn.ReadOnly = true;
            this.driversDataGridViewTextBoxColumn.Width = 150;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 981);
            this.Controls.Add(this.txtSelectedDriverId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCofnij);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtKierowca);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnWybierzKierowce);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAktualizuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.dTPInsurance);
            this.Controls.Add(this.dTPReview);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource vehicleBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPlate;
        private TextBox txtBrand;
        private TextBox txtYear;
        private TextBox txtColor;
        private DateTimePicker dTPReview;
        private DateTimePicker dTPInsurance;
        private BindingSource vehicleBindingSource1;
        private Button btnUsun;
        private Button btnAktualizuj;
        private Button btnDodaj;
        private DataGridView dataGridView1;
        private BindingSource vehicleBindingSource2;
        private Button btnWybierzKierowce;
        private Label label7;
        private TextBox txtModel;
        private TextBox txtKierowca;
        private TextBox txtId;
        private Label label8;
        private Button btnCofnij;
        private Button btnClose;
        private TextBox txtSelectedDriverId;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextReviewDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextInsuranceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driversDataGridViewTextBoxColumn;
    }
}