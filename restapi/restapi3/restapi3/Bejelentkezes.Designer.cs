
namespace restapi3
{
    partial class Bejelentkezes
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
            this.Felhasználónév = new System.Windows.Forms.TextBox();
            this.Jelszó = new System.Windows.Forms.TextBox();
            this.Felhasználónév_Label = new System.Windows.Forms.Label();
            this.Jelszó_Label = new System.Windows.Forms.Label();
            this.Bejelentkezés = new System.Windows.Forms.Button();
            this.Kilépés = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Felhasználónév
            // 
            this.Felhasználónév.Location = new System.Drawing.Point(124, 10);
            this.Felhasználónév.Name = "Felhasználónév";
            this.Felhasználónév.Size = new System.Drawing.Size(146, 22);
            this.Felhasználónév.TabIndex = 0;
            // 
            // Jelszó
            // 
            this.Jelszó.Location = new System.Drawing.Point(124, 40);
            this.Jelszó.Name = "Jelszó";
            this.Jelszó.PasswordChar = '*';
            this.Jelszó.Size = new System.Drawing.Size(146, 22);
            this.Jelszó.TabIndex = 1;
            // 
            // Felhasználónév_Label
            // 
            this.Felhasználónév_Label.AutoSize = true;
            this.Felhasználónév_Label.Location = new System.Drawing.Point(7, 13);
            this.Felhasználónév_Label.Name = "Felhasználónév_Label";
            this.Felhasználónév_Label.Size = new System.Drawing.Size(111, 17);
            this.Felhasználónév_Label.TabIndex = 2;
            this.Felhasználónév_Label.Text = "Felhasználónév:";
            // 
            // Jelszó_Label
            // 
            this.Jelszó_Label.AutoSize = true;
            this.Jelszó_Label.Location = new System.Drawing.Point(7, 43);
            this.Jelszó_Label.Name = "Jelszó_Label";
            this.Jelszó_Label.Size = new System.Drawing.Size(52, 17);
            this.Jelszó_Label.TabIndex = 3;
            this.Jelszó_Label.Text = "Jelszó:";
            // 
            // Bejelentkezés
            // 
            this.Bejelentkezés.Location = new System.Drawing.Point(65, 85);
            this.Bejelentkezés.Name = "Bejelentkezés";
            this.Bejelentkezés.Size = new System.Drawing.Size(131, 23);
            this.Bejelentkezés.TabIndex = 4;
            this.Bejelentkezés.Text = "Bejelentkezés";
            this.Bejelentkezés.UseVisualStyleBackColor = true;
            this.Bejelentkezés.Click += new System.EventHandler(this.Bejelentkezés_Click);
            // 
            // Kilépés
            // 
            this.Kilépés.Location = new System.Drawing.Point(65, 114);
            this.Kilépés.Name = "Kilépés";
            this.Kilépés.Size = new System.Drawing.Size(131, 23);
            this.Kilépés.TabIndex = 5;
            this.Kilépés.Text = "Kilépés";
            this.Kilépés.UseVisualStyleBackColor = true;
            this.Kilépés.Click += new System.EventHandler(this.Kilépés_Click);
            // 
            // Bejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 142);
            this.Controls.Add(this.Kilépés);
            this.Controls.Add(this.Bejelentkezés);
            this.Controls.Add(this.Jelszó_Label);
            this.Controls.Add(this.Felhasználónév_Label);
            this.Controls.Add(this.Jelszó);
            this.Controls.Add(this.Felhasználónév);
            this.Name = "Bejelentkezes";
            this.Text = "Bejelentkezes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Felhasználónév;
        private System.Windows.Forms.TextBox Jelszó;
        private System.Windows.Forms.Label Felhasználónév_Label;
        private System.Windows.Forms.Label Jelszó_Label;
        private System.Windows.Forms.Button Bejelentkezés;
        private System.Windows.Forms.Button Kilépés;
    }
}