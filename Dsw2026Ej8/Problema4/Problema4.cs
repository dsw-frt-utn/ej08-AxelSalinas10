namespace Dsw2026Ej8.Problema4
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notas = new int?[] { nota1, nota2, nota3 };

            var validas = notas
                .Where(n => n.HasValue && n >= 0 && n <= 10)
                .Select(n => n.Value)
                .ToList();

            if (validas.Count == 0)
                return 0;

            return validas.Average();
        }
    }
}