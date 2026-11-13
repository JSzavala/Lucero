namespace Lucero.Modelos
{
    public class DetalleGuia
    {
        public TipoGuia Tipo { get; set; }
        public string Numero { get; set; }
        public string Contenido { get; set; }
        public decimal Peso { get; set; }
        public decimal ValorUnitarioPorCuota { get; set; }
        public bool RetieneIva { get; set; }
        public string Embalaje { get; set; }

        public decimal Importe
        {
            get { return Peso * ValorUnitarioPorCuota; }
        }
    }
}
