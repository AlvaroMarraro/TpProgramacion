
namespace FerremaniaFront
{
    partial class FrmLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblIncorrecto = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.panel2.Location = new System.Drawing.Point(573, 688);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 5);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(573, 799);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 5);
            this.panel1.TabIndex = 20;
            // 
            // LblIncorrecto
            // 
            this.LblIncorrecto.AutoSize = true;
            this.LblIncorrecto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIncorrecto.ForeColor = System.Drawing.Color.DarkRed;
            this.LblIncorrecto.Location = new System.Drawing.Point(699, 688);
            this.LblIncorrecto.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LblIncorrecto.Name = "LblIncorrecto";
            this.LblIncorrecto.Size = new System.Drawing.Size(185, 37);
            this.LblIncorrecto.TabIndex = 18;
            this.LblIncorrecto.Text = "* Obligatorio";
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPass.ForeColor = System.Drawing.Color.LightGray;
            this.TxtPass.Location = new System.Drawing.Point(492, 733);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(610, 50);
            this.TxtPass.TabIndex = 17;
            this.TxtPass.Text = "Ingrese PASSWORD";
            this.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogin.Location = new System.Drawing.Point(1089, 709);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(537, 74);
            this.BtnLogin.TabIndex = 15;
            this.BtnLogin.Text = "INGRESAR";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUser.ForeColor = System.Drawing.Color.LightGray;
            this.TxtUser.Location = new System.Drawing.Point(492, 309);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(610, 50);
            this.TxtUser.TabIndex = 16;
            this.TxtUser.Text = "USUARIO";
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FerremaniaFront.Properties.Resources.FondoLogin;
            this.ClientSize = new System.Drawing.Size(1661, 1088);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblIncorrecto);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblIncorrecto;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtUser;
    }
}