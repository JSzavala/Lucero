using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lucero.Modelos
{
    public class GuiaFactura
    {
        public DateTime Fecha { get; set; }
        public Oficina Oficina { get; set; }
        public string Lugar { get; set; }
        public string Folio { get; set; }

        public string Origen { get; set; }
        public string Remitente { get; set; }
        public string DomicilioRemitente { get; set; }
        public string RfcRemitente { get; set; }
        public string SeRecogeraEn { get; set; }

        public string Destino { get; set; }
        public string Destinatario { get; set; }
        public string DomicilioDestinatario { get; set; }
        public string RfcDestinatario { get; set; }
        public string SeEntregaraEn { get; set; }

        public decimal ValorDeclarado { get; set; }
        public decimal Flete { get; set; }
        public decimal Maniobras { get; set; }
        public decimal CobroPorSeguro { get; set; }
        public decimal Otros { get; set; }
        public decimal Alyt { get; set; }
        public decimal Suma { get; set; }
        public decimal RetenerIva { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }

        public bool Pagado { get; set; }
        public bool SeguroPagado { get; set; }

        public string ObservacionesDdf { get; set; }
        public string Reembarco { get; set; }
        public string Condujo { get; set; }
        public string Observaciones { get; set; }
        public string ReembarcarseCon { get; set; }
        public string Conducira { get; set; }
        public string Usuario { get; set; }

        [Browsable(false)]
        public List<DetalleGuia> Detalles { get; set; } = new List<DetalleGuia>();

        public GuiaFactura()
        {
            Fecha = DateTime.Today;
        }
    }
}
