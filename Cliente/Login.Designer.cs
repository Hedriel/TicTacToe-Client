using Cliente.Modelo;
using System;
using System.Drawing;

namespace Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.linkLabelRegistrar = new System.Windows.Forms.LinkLabel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(182, 146);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // linkLabelRegistrar
            // 
            this.linkLabelRegistrar.AutoEllipsis = true;
            this.linkLabelRegistrar.AutoSize = true;
            this.linkLabelRegistrar.Location = new System.Drawing.Point(301, 260);
            this.linkLabelRegistrar.Name = "linkLabelRegistrar";
            this.linkLabelRegistrar.Size = new System.Drawing.Size(55, 13);
            this.linkLabelRegistrar.TabIndex = 1;
            this.linkLabelRegistrar.TabStop = true;
            this.linkLabelRegistrar.Text = "Registrate";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(238, 69);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(42, 13);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "TaTeTi";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(294, 149);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 51);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(115, 149);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(115, 187);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(182, 184);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Location = new System.Drawing.Point(179, 260);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(101, 13);
            this.labelPregunta.TabIndex = 7;
            this.labelPregunta.Text = "¿No tienes Cuenta?";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(179, 210);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 347);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.linkLabelRegistrar);
            this.Controls.Add(this.textBoxUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "TaTeTi";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        public Boolean VerificarCampos()
        {
            if(this.textBoxUsuario.Text == "" || this.textBoxPassword.Text == "")
            {
                this.textBoxUsuario.BackColor = Color.IndianRed;
                textBoxPassword.BackColor = Color.IndianRed;
                this.labelError.Text = "Usuario y/o contraseña Invalidos";
                return false;
            }else{ 
                return true;
            }
           
        }
        public void TacharCampos()
        {
            
                this.textBoxUsuario.BackColor = Color.IndianRed;
                textBoxPassword.BackColor = Color.IndianRed;
                this.labelError.Text = "Usuario y/o contraseña Invalidos";
            

        }

        public String getUsuario()
        {
            return this.textBoxUsuario.Text;
        }
        public String getPassword()
        {
            return this.textBoxPassword.Text;
        }
        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.LinkLabel linkLabelRegistrar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label labelError;

     
    }
}

