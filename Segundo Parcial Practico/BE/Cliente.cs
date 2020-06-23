using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public  class Cliente
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IntId value.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the VarNombre value.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the VarApellido value.
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Gets or sets the VarDireccion value.
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Gets or sets the VarTelefono value.
        /// </summary>
        public string Telefono { get; set; }

        #endregion
    }
}
