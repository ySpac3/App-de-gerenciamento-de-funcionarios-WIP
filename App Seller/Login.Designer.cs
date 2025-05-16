namespace App_Seller
{
    partial class Login
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
            this.tbName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCdg = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Bold);
            this.tbName.Location = new System.Drawing.Point(175, 186);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbName.Size = new System.Drawing.Size(200, 32);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "";
            this.tbName.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(72, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOME:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(175, 240);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbPassword.Size = new System.Drawing.Size(200, 32);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Text = "";
            this.tbPassword.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(61, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "SENHA:";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbCdg
            // 
            this.tbCdg.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCdg.Location = new System.Drawing.Point(175, 294);
            this.tbCdg.Multiline = false;
            this.tbCdg.Name = "tbCdg";
            this.tbCdg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbCdg.Size = new System.Drawing.Size(200, 32);
            this.tbCdg.TabIndex = 0;
            this.tbCdg.Text = "";
            this.tbCdg.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(97, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "CDG:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogar.Location = new System.Drawing.Point(132, 345);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(200, 40);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "LOGAR";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCdg);
            this.Controls.Add(this.tbPassword);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 480);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbCdg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogar;
    }
}