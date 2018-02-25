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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_jelszo = new System.Windows.Forms.TextBox();
            this.tb_jelszo_ujra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Regisztrálás = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(123, 44);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 0;
            // 
            // tb_jelszo
            // 
            this.tb_jelszo.Location = new System.Drawing.Point(123, 88);
            this.tb_jelszo.Name = "tb_jelszo";
            this.tb_jelszo.Size = new System.Drawing.Size(100, 20);
            this.tb_jelszo.TabIndex = 1;
            // 
            // tb_jelszo_ujra
            // 
            this.tb_jelszo_ujra.Location = new System.Drawing.Point(123, 134);
            this.tb_jelszo_ujra.Name = "tb_jelszo_ujra";
            this.tb_jelszo_ujra.Size = new System.Drawing.Size(100, 20);
            this.tb_jelszo_ujra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-mail cím";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jelszó megerősítése";
            // 
            // btn_Regisztrálás
            // 
            this.btn_Regisztrálás.Location = new System.Drawing.Point(84, 178);
            this.btn_Regisztrálás.Name = "btn_Regisztrálás";
            this.btn_Regisztrálás.Size = new System.Drawing.Size(139, 34);
            this.btn_Regisztrálás.TabIndex = 6;
            this.btn_Regisztrálás.Text = "Regisztrálás";
            this.btn_Regisztrálás.UseVisualStyleBackColor = true;
            this.btn_Regisztrálás.Click += new System.EventHandler(this.btn_Regisztrálás_Click);
            // 
            // Regisztracios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Regisztrálás);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_jelszo_ujra);
            this.Controls.Add(this.tb_jelszo);
            this.Controls.Add(this.tb_email);
            this.Name = "Regisztracios_Form";
            this.Text = "Regisztracios_Form";
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
    }
}