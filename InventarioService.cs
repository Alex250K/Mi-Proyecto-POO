using InventarioLibreria.Models;

namespace InventarioLibreria.Services
{
    public class InventarioService
    {
        private List<Libro> libros = new();
        private List<Venta> ventas = new();

        // Método integrado con validación estricta de campos vacíos y tipos
        public void AgregarLibro()
        {
            Console.Write("Título: ");
            string? titulo = Console.ReadLine()?.Trim();
            Console.Write("Autor: ");
            string? autor = Console.ReadLine()?.Trim();
            Console.Write("ISBN: ");
            string? isbn = Console.ReadLine()?.Trim();
            Console.Write("Precio: ");
            string? precioInput = Console.ReadLine()?.Trim();
            Console.Write("Stock: ");
            string? stockInput = Console.ReadLine()?.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(titulo) ||
                string.IsNullOrWhiteSpace(autor) ||
                string.IsNullOrWhiteSpace(isbn) ||
                string.IsNullOrWhiteSpace(precioInput) ||
                string.IsNullOrWhiteSpace(stockInput))
            {
                Console.WriteLine("Error: Todos los campos son obligatorios. No se ha registrado el libro.");
                return;
            }

            // Validación de tipos de datos
            decimal precio;
            int stock;
            bool precioValido = decimal.TryParse(precioInput, out precio) && precio > 0;
            bool stockValido = int.TryParse(stockInput, out stock) && stock >= 0;

            if (!precioValido)
            {
                Console.WriteLine("Error: El precio debe ser un número mayor a 0.");
                return;
            }
            if (!stockValido)
            {
                Console.WriteLine("Error: El stock debe ser un número entero igual o mayor a 0.");
                return;
            }

            Libro libro = new(titulo, autor, isbn, precio, stock);
            libros.Add(libro);
            Console.WriteLine("Libro agregado exitosamente.");
        }

        public void ConsultarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en el inventario.");
                return;
            }

            Console.WriteLine("\nLibros en inventario:");
            foreach (var libro in libros)
                libro.MostrarInfo();
        }

        public void ActualizarLibro()
        {
            Console.Write("Ingrese ISBN del libro a actualizar: ");
            string? isbn = Console.ReadLine();
            var libro = libros.FirstOrDefault(l => l.ISBN == isbn);

            if (libro == null)
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }

            Console.WriteLine("Deje vacío para no modificar.");
            Console.Write($"Nuevo título ({libro.Titulo}): ");
            string? titulo = Console.ReadLine();
            Console.Write($"Nuevo autor ({libro.Autor}): ");
            string? autor = Console.ReadLine();
            Console.Write($"Nuevo precio ({libro.Precio}): ");
            string? precioStr = Console.ReadLine();
            Console.Write($"Nuevo stock ({libro.Stock}): ");
            string? stockStr = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(titulo)) libro.Titulo = titulo;
            if (!string.IsNullOrWhiteSpace(autor)) libro.Autor = autor;
            if (decimal.TryParse(precioStr, out decimal precio)) libro.Precio = precio;
            if (int.TryParse(stockStr, out int stock)) libro.Stock = stock;

            Console.WriteLine("Libro actualizado.");
        }

        public void EliminarLibro()
        {
            Console.Write("Ingrese ISBN del libro a eliminar: ");
            string? isbn = Console.ReadLine();
            var libro = libros.FirstOrDefault(l => l.ISBN == isbn);

            if (libro == null)
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }

            libros.Remove(libro);
            Console.WriteLine("Libro eliminado.");
        }

        public void RegistrarVenta()
        {
            Console.Write("Ingrese ISBN del libro vendido: ");
            string? isbn = Console.ReadLine();
            var libro = libros.FirstOrDefault(l => l.ISBN == isbn);

            if (libro == null)
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }

            Console.Write("Cantidad vendida: ");
            int cantidad = int.TryParse(Console.ReadLine(), out int c) ? c : 0;

            if (cantidad <= 0 || cantidad > libro.Stock)
            {
                Console.WriteLine("Cantidad inválida o insuficiente stock.");
                return;
            }

            libro.Stock -= cantidad;
            Venta venta = new(libro, cantidad);
            ventas.Add(venta);
            Console.WriteLine("Venta registrada correctamente.");
        }

        public void VerReportes()
        {
            Console.WriteLine("\n--- Reporte de Stock ---");
            foreach (var libro in libros)
                libro.MostrarInfo();

            Console.WriteLine("\n--- Reporte de Ventas ---");
            if (ventas.Count == 0)
            {
                Console.WriteLine("No hay ventas registradas.");
            }
            else
            {
                foreach (var venta in ventas)
                    venta.MostrarVenta();
            }
        }
    }
}