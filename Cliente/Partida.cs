using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Modelo
{
    public partial class Partida : Form
    {
        Usuario host;
        Usuario rival;
        ConexionCliente conexion;
        public Partida(Usuario host, Usuario rival, ConexionCliente conexion)
        {
            InitializeComponent();
            this.host = host;
            this.rival = rival;
            this.conexion = conexion;

            this.labelJugador.Text = host.getNombre();
            this.labelRival.Text = rival.getNombre();
        }
        public Partida()
        {
            InitializeComponent();
        }

        public void setAtributos(Usuario host,Usuario rival, ConexionCliente conexion)
        {
            this.host = host;
            this.rival = rival;
            this.conexion = conexion;

            this.labelJugador.Text = host.getNombre();
            this.labelRival.Text = rival.getNombre();

        }
        public void enablePlay()
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
