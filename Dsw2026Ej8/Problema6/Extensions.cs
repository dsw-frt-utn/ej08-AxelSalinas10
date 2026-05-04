namespace Dsw2026Ej8.Problema6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
                return "SIN-CODIGO";

            return code
                .Trim()        // elimina espacios al inicio y final
                .ToUpper()     // convierte a mayúsculas
                .Replace(" ", "-"); // reemplaza espacios por guiones
        }
    }
}