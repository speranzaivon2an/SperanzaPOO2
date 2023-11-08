namespace Entidad
{
    public class AsientosContables
    {
        public int AsientosContablesID { get; set; }
        public TimeSpan Fecha { get; set; }

        CapitalActual capital { get; set; }
        Concepto concepto { get; set; }
        List<DEBE> debe { get; set; }
        List<HABER> haber { get; set; }

    }
}