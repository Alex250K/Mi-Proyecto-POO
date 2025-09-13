namespace InventarioLibreria.Models
{
    // La clase 'Producto' es una clase abstracta. Esto significa que no se puede
    // crear una instancia directa de 'Producto'. En su lugar, está diseñada
    // para ser la clase base de otras clases (como 'Libro') que la hereden.
    // Contiene propiedades y métodos comunes a todos los tipos de productos.
    public abstract class Producto
    {
        public string Titulo { get; set; }    // Propiedad pública para el título del producto. 'get; set;' permite // leer y escribir el valor de la propiedad.                                         
        public decimal Precio { get; set; }

        public Producto(string titulo, decimal precio)
        {
            Titulo = titulo;
            Precio = precio;
        }

        public abstract void MostrarInfo();
    }
}

        // Este es un método abstracto. Esto significa que no tiene una implementación
        // en esta clase. Cualquier clase que herede de 'Producto' (una clase "hija")
        // DEBE proporcionar su propia implementación para este método.
        // Se usa para asegurar que todos los productos puedan mostrar su información
        // de una manera consistente, pero con detalles específicos para cada tipo de producto.
