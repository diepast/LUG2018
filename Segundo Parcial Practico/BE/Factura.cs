using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Factura
    {
        #region Properties
		/// <summary>
		/// Gets or sets the IntId value.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the DatFecha value.
		/// </summary>
		public DateTime Fecha { get; set; }

		/// <summary>
		/// Gets or sets the IntIdCliente value.
		/// </summary>
		public BE.Cliente Cliente { get; set; }

        private List<BE.DetalleFactura> _detalle;

        public Factura()
        {
            this._detalle = new List<BE.DetalleFactura>();
        }
        

        public List<BE.DetalleFactura> getDetalle()
        {
            return this._detalle;
        
        }
        public void setDetalle(BE.DetalleFactura detalle)
        {
            this._detalle.Add(detalle);

        }
		#endregion



    }
}
