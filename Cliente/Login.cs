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
    public partial class Login : Form
    {
        LogicaForms logicaLogin;
        public Login()
        {
            InitializeComponent();
            logicaLogin = new LogicaForms(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {            
            logicaLogin.VerificarCampos();            
        }

       
    }
}
