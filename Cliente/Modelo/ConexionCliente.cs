using Cliente.Modelo;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Cliente
{
    public class ConexionCliente
    {
        LogicaForms logicaForms;
        Usuario user;
        string msgRec;
        static NetworkStream stream;
        byte[] bytesFrom;
        Usuario rival;
        static Boolean rivalEncontrado = false;

        Thread threadPartida;
        Thread threadClient;


        public ConexionCliente(Usuario user,LogicaForms logicaForms)
        {
            this.user = user;
            this.logicaForms = logicaForms;
            TcpClient socket = new TcpClient();



            Console.WriteLine("Iniciando cliente");

            // 127.0.0.1 : Localhost
            socket.Connect("127.0.0.1", 8000);
            stream = socket.GetStream();
            // Enviar mensaje

            string objetoUser = JsonConvert.SerializeObject(user);
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(objetoUser);
            stream.Write(sendBytes, 0, sendBytes.Length);

            // Recibir mensaje
            bytesFrom = new byte[8];

            stream.Read(bytesFrom, 0, bytesFrom.Length);
            string msgRec = System.Text.Encoding.ASCII.GetString(bytesFrom);
            stream.Flush();
            Console.WriteLine(msgRec);
            this.msgRec = msgRec;
            usuarioAceptado();

            this.threadClient   = new Thread(escucharServer);
            this.threadPartida  = new Thread(crearPartida);

            threadClient.Start();
        


        }

        private Boolean verificarUser(string msg)
        {
            if (msg == "aceptado") {
                Console.WriteLine("este metodo funciona");
                return true;
            } else {
                Console.WriteLine("este metodo no funciona");
                return false;
            }
        }

        public Boolean usuarioAceptado()
        {
            if (verificarUser(msgRec))
            {
                return true;
            } else {
                return false;
            }
        }

        internal void ponerEnCola()
        {
            enviarString("c");
        }

        internal void salirDeCola()
        {
            enviarString("d");
        }

        public void cerrarConexion()
        {
            enviarString("o");
        }

        private void enviarString(String mensaje)
        {
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(mensaje);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();
        }

        private void interpretarMensaje(String msg)
        {
            if (msg.Equals(rival.getNombre()))
            {
                /// Empieza el segundo que encontro
                Console.WriteLine("VAS VOOOOS");
                logicaForms.unlockButton();
            }
        }

     
        private void escucharServer()
        {
            while (true) 
            { 
                 
                byte[] bytesFrom = new byte[4]; // tamaño int
                stream.Read(bytesFrom, 0, bytesFrom.Length);
                int buffersize = BitConverter.ToInt32(bytesFrom, 0);
                bytesFrom = new byte[buffersize]; // tamaño mensaje

                stream.Read(bytesFrom, 0, bytesFrom.Length);
                string recived = System.Text.Encoding.ASCII.GetString(bytesFrom);

                if (!rivalEncontrado) {
                    Console.WriteLine(recived);
                    this.rival = JsonConvert.DeserializeObject<Usuario>(recived); 
                    rivalEncontrado = true;
                    threadPartida.Start();
                    enviarString("w");
                }
                else 
                {
                    interpretarMensaje(recived);
                }
            }
        }

        private void crearPartida()
        { 
            logicaForms.jugar(user,rival);
           
        }
    }
}
