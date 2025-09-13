namespace InventarioLibreria.Models
{
    public class Venta
    {
        public Libro LibroVendido { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public Venta(Libro libro, int cantidad)
        {
            LibroVendido = libro;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
        }

        public void MostrarVenta()
        {
            Console.WriteLine($"{Fecha:dd/MM/yyyy HH:mm} | {LibroVendido.Titulo} | Cantidad: {Cantidad} | Total: {(LibroVendido.Precio * Cantidad):C}");
        }
    }
}
