using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class DetalleFactura
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IntId value.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the IntIdProducto value.
        /// </summary>
        /// 
        private BE.Producto _producto;

        public BE.Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        
        /// <summary>
        /// Gets or sets the IntCantidad value.
        /// </summary>
        public int Cantidad { get; set; }

        public DetalleFactura()
        {
            this._producto = new BE.Producto();
        
        }

        #endregion
    }
}
