namespace Dsw2026Ej8.Problema3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue;
            copiaValor++;

            Product copiaProducto = product;
            copiaProducto.SetDescription("Nuevo producto");

            return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
        }
    }
}