using Cliente.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Menu : Form
    {
        LogicaForms logicaMenu;
        Usuario user;
        public Menu(Usuario user)
        {
            InitializeComponent();
            logicaMenu = new LogicaForms(this);
            this.user = user;
            this.labelNombre.Text = user.getNombre();
            this.buttonSalirDeCola.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logicaMenu.cerrarMenu();
        }

        private void buttonPonerEnCola_Click(object sender, EventArgs e)
        {
            logicaMenu.ponerEnCola();
            this.buttonPonerEnCola.Hide();
            this.buttonSalirDeCola.Show();
        }

        private void buttonSacarDeCola_Click(object sender, EventArgs e)
        {
            logicaMenu.salirDeCola();
            this.buttonSalirDeCola.Hide();
            this.buttonPonerEnCola.Show();
          
        }
    }
}
