using CajeroMenuC.Servicios;

namespace CajeroMenuC.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 250923 -> irm
    /// </summary>
    class Program 
    { 
        /// <summary>
        /// Metodo de entrada en la aplicacion
        /// 250923 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args) 
        {   

            MenuInterfaz menuInt = new MenuImplementacion();
            menuInt.mostrarMensajeBienvenida();
            //Variable que controla la entrada y salida del bucle
            bool cerrarMenu = false;
            //guardar la opcion del usuario
            int opcionSeleccionada;
            //desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInt.mostrarMenuYSeleccionado();
                switch (opcionSeleccionada)
                {
                    case 0:

                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no existe");
                }
            }
        }        
    }
}