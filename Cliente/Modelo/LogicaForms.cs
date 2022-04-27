using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Modelo
{
    public class LogicaForms
    {
        Login formLogin;
        Menu formMenu;
        public Partida formPartida = new Partida();

        Usuario user;
        static ConexionCliente conexion;

        public LogicaForms(Login formLogin)
        {
            this.formLogin = formLogin;
        }
        public LogicaForms(Menu formMenu)
        {
            this.formMenu = formMenu;
        }
        public LogicaForms(Partida formPartida)
        {
            this.formPartida = formPartida;
        }




        public void VerificarCampos(){
            if (formLogin.VerificarCampos()){
                user = new Usuario(formLogin.getUsuario(), formLogin.getPassword());
                conexion = new ConexionCliente(user,this);
               
                if (conexion.usuarioAceptado())
                {      
                    formMenu = new Menu(user);
                    formMenu.Show(formLogin);
                    formLogin.Hide();
                }
                else
                {
                    formLogin.TacharCampos();
                }
                

            }        
        }

        public void cerrarMenu() 
        {
            conexion.cerrarConexion();
            formLogin = new Login();
            formLogin.Show();
            formMenu.Hide(); 
        }
    

        public void ponerEnCola()
        {
            conexion.ponerEnCola();
        }

        public void salirDeCola()
        {
            conexion.salirDeCola();      
        }

        public void jugar(Usuario host, Usuario rival)
        {
            this.formMenu.Hide();
            formPartida.setAtributos(host,rival,conexion);
            formPartida.ShowDialog();
          
        }
        public void unlockButton()
        {
            formPartida.enablePlay();
        }
    }
}
