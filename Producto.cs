namespace InventarioLibreria.Models
{
    public abstract class Producto
    {
        public string Titulo { get; set; }
        public decimal Precio { get; set; }

        public Producto(string titulo, decimal precio)
        {
            Titulo = titulo;
            Precio = precio;
        }

        public abstract void MostrarInfo();
    }
}
