using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Producto
    {
       
        #region Properties
        /// <summary>
        /// Gets or sets the IntId value.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the VarNombre value.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Gets or sets the DecPrecio value.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Gets or sets the IntStock value.
        /// </summary>
        public int Stock { get; set; }

        #endregion


        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("ID: "+ this.Id.ToString());
            stb.AppendLine("Descripcion: " + this.Descripcion.ToString());
            stb.AppendLine("Precio: " + this.Precio.ToString());
            stb.AppendLine("Stock: " + this.Stock.ToString());
            return stb.ToString();
        }
    }
}
