namespace Dsw2026Ej8.Problema1
{
    public static partial class ProductHelper
    {
        public static string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return $"[{code}] {description} - {FormatearPrecio(price)}";
        }
    }
}