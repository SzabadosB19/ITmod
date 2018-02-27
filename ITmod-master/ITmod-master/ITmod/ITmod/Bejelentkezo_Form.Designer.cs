namespace ITmod
{
    partial class Bejelentkezo_Form
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
            this.btn_Bejelentkezes = new System.Windows.Forms.Button();
            this.tb_jelszo = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Bejelentkezes
            // 
            this.btn_Bejelentkezes.Location = new System.Drawing.Point(128, 164);
            this.btn_Bejelentkezes.Name = "btn_Bejelentkezes";
            this.btn_Bejelentkezes.Size = new System.Drawing.Size(83, 23);
            this.btn_Bejelentkezes.TabIndex = 3;
            this.btn_Bejelentkezes.Text = "Bejelentkezés";
            this.btn_Bejelentkezes.UseVisualStyleBackColor = true;
            this.btn_Bejelentkezes.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_jelszo
            // 
            this.tb_jelszo.Location = new System.Drawing.Point(119, 123);
            this.tb_jelszo.Name = "tb_jelszo";
            this.tb_jelszo.Size = new System.Drawing.Size(100, 20);
            this.tb_jelszo.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(119, 63);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail cím";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jelszó";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(52, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(262, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ha még nem regisztráltál, ide kattintva tudod megtenni";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Bejelentkezo_Form
            // 
            this.AcceptButton = this.btn_Bejelentkezes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 295);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_jelszo);
            this.Controls.Add(this.btn_Bejelentkezes);
            this.Name = "Bejelentkezo_Form";
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.Bejelentkezo_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Bejelentkezes;
        private System.Windows.Forms.TextBox tb_jelszo;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

