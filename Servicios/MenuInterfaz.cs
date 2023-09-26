using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Interfaz con la relacion de los metodos del menu
    /// 250923 -> irm
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra un mensaje de bienvenida
        /// 250923 -> irm
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menuy la seleccion del usuario
        /// 260923 -> irm
        /// </summary>
        /// <returns>un entero con la opcion seleccionada</returns>
        int mostrarMenuYSeleccionado();
    }
}
