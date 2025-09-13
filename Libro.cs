namespace InventarioLibreria.Models
{
    public class Libro : Producto
    {
        public string Autor { get; set; }
        public string ISBN { get; set; }
        private int stock;

        public int Stock
        {
            get => stock;
            set => stock = value >= 0 ? value : 0;
        }

        public Libro(string titulo, string autor, string isbn, decimal precio, int stock)
            : base(titulo, precio)
        {
            Autor = autor;
            ISBN = isbn;
            Stock = stock;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"{Titulo} - {Autor} | ISBN: {ISBN} | Stock: {Stock} | Precio: {Precio:C}");
        }
    }
}