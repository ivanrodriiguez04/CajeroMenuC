using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del menu
    /// 250923 -> irm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Bienvenido a CSI1";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("0.Cerrar apliacion");
            Console.WriteLine("1.Darse de alta");
            Console.WriteLine("2.Ingresar dinero");
            Console.WriteLine("3.Sacar dinero");
            Console.WriteLine("4.Transferir dinero");
            Console.WriteLine("5. Historial de aplicaciones");
            Console.WriteLine("Seleccione una opcion:");

            opcionIntroducida=Console.ReadKey(true).KeyChar;

            return opcionIntroducida;
        }
    }
}
