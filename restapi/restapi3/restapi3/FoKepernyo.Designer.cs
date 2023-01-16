namespace restapi3
{
    partial class FoKepernyo
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
            this.ID = new System.Windows.Forms.TextBox();
            this.Visszaad = new System.Windows.Forms.ListBox();
            this.Funkciok = new System.Windows.Forms.ComboBox();
            this.START = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.NevLabel = new System.Windows.Forms.Label();
            this.DarabLabel = new System.Windows.Forms.Label();
            this.ArLabel = new System.Windows.Forms.Label();
            this.AddAr = new System.Windows.Forms.TextBox();
            this.AddDarab = new System.Windows.Forms.TextBox();
            this.AddNev = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.IdLbel = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.Button();
            this.Bejelentkezés = new System.Windows.Forms.Button();
            this.Kilépés = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(57, 182);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(103, 22);
            this.ID.TabIndex = 3;
            // 
            // Visszaad
            // 
            this.Visszaad.FormattingEnabled = true;
            this.Visszaad.ItemHeight = 16;
            this.Visszaad.Location = new System.Drawing.Point(13, 42);
            this.Visszaad.Margin = new System.Windows.Forms.Padding(4);
            this.Visszaad.Name = "Visszaad";
            this.Visszaad.Size = new System.Drawing.Size(770, 132);
            this.Visszaad.TabIndex = 4;
            // 
            // Funkciok
            // 
            this.Funkciok.FormattingEnabled = true;
            this.Funkciok.Items.AddRange(new object[] {
            "GET",
            "GET(ID)",
            "DELETE(ID)"});
            this.Funkciok.Location = new System.Drawing.Point(13, 12);
            this.Funkciok.Name = "Funkciok";
            this.Funkciok.Size = new System.Drawing.Size(121, 24);
            this.Funkciok.TabIndex = 9;
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(150, 12);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 10;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(231, 13);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 23);
            this.CLEAR.TabIndex = 12;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // NevLabel
            // 
            this.NevLabel.AutoSize = true;
            this.NevLabel.Location = new System.Drawing.Point(167, 185);
            this.NevLabel.Name = "NevLabel";
            this.NevLabel.Size = new System.Drawing.Size(41, 17);
            this.NevLabel.TabIndex = 13;
            this.NevLabel.Text = "Név: ";
            // 
            // DarabLabel
            // 
            this.DarabLabel.AutoSize = true;
            this.DarabLabel.Location = new System.Drawing.Point(320, 185);
            this.DarabLabel.Name = "DarabLabel";
            this.DarabLabel.Size = new System.Drawing.Size(55, 17);
            this.DarabLabel.TabIndex = 14;
            this.DarabLabel.Text = "Darab: ";
            // 
            // ArLabel
            // 
            this.ArLabel.AutoSize = true;
            this.ArLabel.Location = new System.Drawing.Point(487, 185);
            this.ArLabel.Name = "ArLabel";
            this.ArLabel.Size = new System.Drawing.Size(30, 17);
            this.ArLabel.TabIndex = 15;
            this.ArLabel.Text = "Ár: ";
            // 
            // AddAr
            // 
            this.AddAr.Location = new System.Drawing.Point(523, 182);
            this.AddAr.Name = "AddAr";
            this.AddAr.Size = new System.Drawing.Size(100, 22);
            this.AddAr.TabIndex = 16;
            // 
            // AddDarab
            // 
            this.AddDarab.Location = new System.Drawing.Point(381, 182);
            this.AddDarab.Name = "AddDarab";
            this.AddDarab.Size = new System.Drawing.Size(100, 22);
            this.AddDarab.TabIndex = 17;
            // 
            // AddNev
            // 
            this.AddNev.Location = new System.Drawing.Point(214, 182);
            this.AddNev.Name = "AddNev";
            this.AddNev.Size = new System.Drawing.Size(100, 22);
            this.AddNev.TabIndex = 18;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(682, 182);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(101, 23);
            this.ADD.TabIndex = 19;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // IdLbel
            // 
            this.IdLbel.AutoSize = true;
            this.IdLbel.Location = new System.Drawing.Point(21, 184);
            this.IdLbel.Name = "IdLbel";
            this.IdLbel.Size = new System.Drawing.Size(29, 17);
            this.IdLbel.TabIndex = 20;
            this.IdLbel.Text = "ID: ";
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(682, 211);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(101, 23);
            this.UPDATE.TabIndex = 21;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // Bejelentkezés
            // 
            this.Bejelentkezés.Location = new System.Drawing.Point(24, 435);
            this.Bejelentkezés.Name = "Bejelentkezés";
            this.Bejelentkezés.Size = new System.Drawing.Size(149, 60);
            this.Bejelentkezés.TabIndex = 22;
            this.Bejelentkezés.Text = "Bejelentkezés";
            this.Bejelentkezés.UseVisualStyleBackColor = true;
            this.Bejelentkezés.Click += new System.EventHandler(this.Bejelentkezés_Click);
            // 
            // Kilépés
            // 
            this.Kilépés.Location = new System.Drawing.Point(179, 435);
            this.Kilépés.Name = "Kilépés";
            this.Kilépés.Size = new System.Drawing.Size(149, 60);
            this.Kilépés.TabIndex = 23;
            this.Kilépés.Text = "Kilépés";
            this.Kilépés.UseVisualStyleBackColor = true;
            this.Kilépés.Click += new System.EventHandler(this.Kilépés_Click);
            // 
            // FoKepernyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 507);
            this.Controls.Add(this.Kilépés);
            this.Controls.Add(this.Bejelentkezés);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.IdLbel);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.AddNev);
            this.Controls.Add(this.AddDarab);
            this.Controls.Add(this.AddAr);
            this.Controls.Add(this.ArLabel);
            this.Controls.Add(this.DarabLabel);
            this.Controls.Add(this.NevLabel);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.START);
            this.Controls.Add(this.Funkciok);
            this.Controls.Add(this.Visszaad);
            this.Controls.Add(this.ID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoKepernyo";
            this.Text = "REST client";
            this.Load += new System.EventHandler(this.FoKepernyo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.ListBox Visszaad;
        private System.Windows.Forms.ComboBox Funkciok;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Label NevLabel;
        private System.Windows.Forms.Label DarabLabel;
        private System.Windows.Forms.Label ArLabel;
        private System.Windows.Forms.TextBox AddAr;
        private System.Windows.Forms.TextBox AddDarab;
        private System.Windows.Forms.TextBox AddNev;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label IdLbel;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button Bejelentkezés;
        private System.Windows.Forms.Button Kilépés;
    }
}

