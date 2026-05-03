using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Problema2;
using Dsw2026Ej8.Problema3;
Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto(123, "Teclado", 1500));
var p2 = new Problema2();
Console.WriteLine(p2.CrearResumenVenta(1, "Mouse", 2, 100));
var p3 = new Problema3();

var producto = new Product();
producto.SetDescription("Original");

Console.WriteLine(p3.CompararCopias(10, producto));