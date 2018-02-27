namespace ITmod
{
    partial class Regisztracios_Form
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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_jelszo = new System.Windows.Forms.TextBox();
            this.tb_jelszo_ujra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Regisztrálás = new System.Windows.Forms.Button();
            this.tb_felhasznalo_nev = new System.Windows.Forms.TextBox();
            this.tb_cim = new System.Windows.Forms.TextBox();
            this.tb_telefon_3 = new System.Windows.Forms.TextBox();
            this.cb_telefon = new System.Windows.Forms.ComboBox();
            this.tb_telefon_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(135, 88);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_jelszo
            // 
            this.tb_jelszo.Location = new System.Drawing.Point(135, 137);
            this.tb_jelszo.Name = "tb_jelszo";
            this.tb_jelszo.PasswordChar = '*';
            this.tb_jelszo.Size = new System.Drawing.Size(100, 20);
            this.tb_jelszo.TabIndex = 2;
            // 
            // tb_jelszo_ujra
            // 
            this.tb_jelszo_ujra.Location = new System.Drawing.Point(135, 192);
            this.tb_jelszo_ujra.Name = "tb_jelszo_ujra";
            this.tb_jelszo_ujra.Size = new System.Drawing.Size(100, 20);
            this.tb_jelszo_ujra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-mail cím";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jelszó megerősítése";
            // 
            // btn_Regisztrálás
            // 
            this.btn_Regisztrálás.Location = new System.Drawing.Point(354, 178);
            this.btn_Regisztrálás.Name = "btn_Regisztrálás";
            this.btn_Regisztrálás.Size = new System.Drawing.Size(139, 34);
            this.btn_Regisztrálás.TabIndex = 9;
            this.btn_Regisztrálás.Text = "Regisztrálás";
            this.btn_Regisztrálás.UseVisualStyleBackColor = true;
            this.btn_Regisztrálás.Click += new System.EventHandler(this.btn_Regisztrálás_Click);
            // 
            // tb_felhasznalo_nev
            // 
            this.tb_felhasznalo_nev.Location = new System.Drawing.Point(354, 40);
            this.tb_felhasznalo_nev.Name = "tb_felhasznalo_nev";
            this.tb_felhasznalo_nev.Size = new System.Drawing.Size(181, 20);
            this.tb_felhasznalo_nev.TabIndex = 4;
            // 
            // tb_cim
            // 
            this.tb_cim.Location = new System.Drawing.Point(354, 88);
            this.tb_cim.Name = "tb_cim";
            this.tb_cim.Size = new System.Drawing.Size(181, 20);
            this.tb_cim.TabIndex = 5;
            // 
            // tb_telefon_3
            // 
            this.tb_telefon_3.Location = new System.Drawing.Point(443, 134);
            this.tb_telefon_3.Name = "tb_telefon_3";
            this.tb_telefon_3.Size = new System.Drawing.Size(60, 20);
            this.tb_telefon_3.TabIndex = 8;
            // 
            // cb_telefon
            // 
            this.cb_telefon.FormattingEnabled = true;
            this.cb_telefon.Items.AddRange(new object[] {
            "20",
            "30",
            "70"});
            this.cb_telefon.Location = new System.Drawing.Point(393, 133);
            this.cb_telefon.Name = "cb_telefon";
            this.cb_telefon.Size = new System.Drawing.Size(44, 21);
            this.cb_telefon.TabIndex = 7;
            // 
            // tb_telefon_1
            // 
            this.tb_telefon_1.Location = new System.Drawing.Point(354, 134);
            this.tb_telefon_1.Name = "tb_telefon_1";
            this.tb_telefon_1.Size = new System.Drawing.Size(33, 20);
            this.tb_telefon_1.TabIndex = 6;
            this.tb_telefon_1.Text = "+36";
            this.tb_telefon_1.TextChanged += new System.EventHandler(this.tb_telefon_1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Felhasználónév";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cím";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefonszám";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Név";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(135, 40);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_nev.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Regisztracios_Form
            // 
            this.AcceptButton = this.btn_Regisztrálás;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 238);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_telefon_1);
            this.Controls.Add(this.cb_telefon);
            this.Controls.Add(this.tb_telefon_3);
            this.Controls.Add(this.tb_cim);
            this.Controls.Add(this.tb_felhasznalo_nev);
            this.Controls.Add(this.btn_Regisztrálás);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_jelszo_ujra);
            this.Controls.Add(this.tb_jelszo);
            this.Controls.Add(this.tb_email);
            this.Name = "Regisztracios_Form";
            this.Text = "Regisztrálás";
            this.Load += new System.EventHandler(this.Regisztracios_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_jelszo;
        private System.Windows.Forms.TextBox tb_jelszo_ujra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Regisztrálás;
        private System.Windows.Forms.TextBox tb_felhasznalo_nev;
        private System.Windows.Forms.TextBox tb_cim;
        private System.Windows.Forms.TextBox tb_telefon_3;
        private System.Windows.Forms.ComboBox cb_telefon;
        private System.Windows.Forms.TextBox tb_telefon_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}