namespace DesktopApp
{
    partial class VehicleMenu
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
            this.btnManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFuel = new System.Windows.Forms.Button();
            this.btnTires = new System.Windows.Forms.Button();
            this.btnProblem = new System.Windows.Forms.Button();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManagement.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnManagement.Location = new System.Drawing.Point(294, 121);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(259, 58);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Zarządzanie autami";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(256, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Co chcesz zrobić?";
            // 
            // btnFuel
            // 
            this.btnFuel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFuel.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnFuel.Location = new System.Drawing.Point(294, 226);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(259, 58);
            this.btnFuel.TabIndex = 2;
            this.btnFuel.Text = "Informacje o paliwie";
            this.btnFuel.UseVisualStyleBackColor = true;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // btnTires
            // 
            this.btnTires.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTires.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnTires.Location = new System.Drawing.Point(294, 328);
            this.btnTires.Name = "btnTires";
            this.btnTires.Size = new System.Drawing.Size(259, 58);
            this.btnTires.TabIndex = 3;
            this.btnTires.Text = "Informacje o oponach";
            this.btnTires.UseVisualStyleBackColor = true;
            this.btnTires.Click += new System.EventHandler(this.btnTires_Click);
            // 
            // btnProblem
            // 
            this.btnProblem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProblem.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnProblem.Location = new System.Drawing.Point(294, 426);
            this.btnProblem.Name = "btnProblem";
            this.btnProblem.Size = new System.Drawing.Size(259, 58);
            this.btnProblem.TabIndex = 4;
            this.btnProblem.Text = "Zgłoszenie usterki";
            this.btnProblem.UseVisualStyleBackColor = true;
            this.btnProblem.Click += new System.EventHandler(this.btnProblem_Click);
            // 
            // btnCofnij
            // 
            this.btnCofnij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofnij.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCofnij.ForeColor = System.Drawing.Color.Black;
            this.btnCofnij.Location = new System.Drawing.Point(12, 12);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(114, 37);
            this.btnCofnij.TabIndex = 24;
            this.btnCofnij.Text = "Cofnij";
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(884, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 37);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VehicleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 574);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCofnij);
            this.Controls.Add(this.btnProblem);
            this.Controls.Add(this.btnTires);
            this.Controls.Add(this.btnFuel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnManagement;
        private Label label1;
        private Button btnFuel;
        private Button btnTires;
        private Button btnProblem;
        private Button btnCofnij;
        private Button btnClose;
    }
}