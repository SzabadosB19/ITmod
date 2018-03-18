namespace Rent_A_Flat
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sajátProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Feltolt = new System.Windows.Forms.Button();
            this.btn_Keres = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sajátProfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sajátProfilToolStripMenuItem
            // 
            this.sajátProfilToolStripMenuItem.Name = "sajátProfilToolStripMenuItem";
            this.sajátProfilToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.sajátProfilToolStripMenuItem.Text = "Saját profil";
            this.sajátProfilToolStripMenuItem.Click += new System.EventHandler(this.sajátProfilToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btn_Feltolt
            // 
            this.btn_Feltolt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Feltolt.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Feltolt.Image = global::Rent_A_Flat.Properties.Resources.upload_icon_good;
            this.btn_Feltolt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Feltolt.Location = new System.Drawing.Point(293, 58);
            this.btn_Feltolt.Name = "btn_Feltolt";
            this.btn_Feltolt.Size = new System.Drawing.Size(194, 92);
            this.btn_Feltolt.TabIndex = 3;
            this.btn_Feltolt.Text = "Feltöltés";
            this.btn_Feltolt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Feltolt.UseVisualStyleBackColor = false;
            this.btn_Feltolt.Click += new System.EventHandler(this.btn_Feltolt_Click);
            // 
            // btn_Keres
            // 
            this.btn_Keres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Keres.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Keres.Image = global::Rent_A_Flat.Properties.Resources.find_icon_good;
            this.btn_Keres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Keres.Location = new System.Drawing.Point(48, 58);
            this.btn_Keres.Name = "btn_Keres";
            this.btn_Keres.Size = new System.Drawing.Size(194, 92);
            this.btn_Keres.TabIndex = 2;
            this.btn_Keres.Text = "Keresés";
            this.btn_Keres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Keres.UseVisualStyleBackColor = false;
            this.btn_Keres.Click += new System.EventHandler(this.btn_Keres_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 230);
            this.Controls.Add(this.btn_Feltolt);
            this.Controls.Add(this.btn_Keres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sajátProfilToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Keres;
        private System.Windows.Forms.Button btn_Feltolt;

    }
}