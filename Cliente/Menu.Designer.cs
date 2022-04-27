namespace Cliente
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPonerEnCola = new System.Windows.Forms.Button();
            this.buttonSalirDeCola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(93, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(186, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Welcome To the Fucking Menu Dude";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(163, 42);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(74, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "(USERNAME)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(137, 169);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPonerEnCola
            // 
            this.buttonPonerEnCola.Location = new System.Drawing.Point(137, 90);
            this.buttonPonerEnCola.Name = "buttonPonerEnCola";
            this.buttonPonerEnCola.Size = new System.Drawing.Size(75, 41);
            this.buttonPonerEnCola.TabIndex = 4;
            this.buttonPonerEnCola.Text = "Poner en Cola";
            this.buttonPonerEnCola.UseVisualStyleBackColor = true;
            this.buttonPonerEnCola.Click += new System.EventHandler(this.buttonPonerEnCola_Click);
            // 
            // buttonSalirDeCola
            // 
            this.buttonSalirDeCola.Location = new System.Drawing.Point(137, 90);
            this.buttonSalirDeCola.Name = "buttonSalirDeCola";
            this.buttonSalirDeCola.Size = new System.Drawing.Size(75, 41);
            this.buttonSalirDeCola.TabIndex = 5;
            this.buttonSalirDeCola.Text = "Salir de Cola";
            this.buttonSalirDeCola.UseVisualStyleBackColor = true;
            this.buttonSalirDeCola.Click += new System.EventHandler(this.buttonSacarDeCola_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 245);
            this.Controls.Add(this.buttonSalirDeCola);
            this.Controls.Add(this.buttonPonerEnCola);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "TaTeTi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPonerEnCola;
        private System.Windows.Forms.Button buttonSalirDeCola;
    }
}