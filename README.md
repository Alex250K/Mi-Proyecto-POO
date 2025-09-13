
# Mi-Proyecto-POO
Gestion de Inventario Simple Para una Libreria

## 1. Caso de Negocio
La librería "Lectura Viva" necesita una aplicación interna para gestionar su inventario de libros. El sistema debe permitir agregar, consultar, actualizar y eliminar libros, registrar ventas y mostrar reportes básicos de stock y ventas.
Actualmente, la librería lleva el control de su inventario de libros y las ventas de forma manual (papel o Excel). Esto genera errores frecuentes, pérdida de información, dificultad para conocer el stock real, y falta de reportes para tomar decisiones rápidas.

## CONTENIDO DEL PROYECTO
- **POO:**  
  - Abstracción: clase abstracta `Producto` y método abstracto `MostrarInfo()`.
  - Encapsulamiento: propiedades privadas/protegidas, acceso controlado.
  - Herencia: `Libro` hereda de `Producto`.
  - Polimorfismo: sobrescritura de métodos, uso de `MostrarInfo()`.

- **Separación de responsabilidades:**  
  - Lógica de negocio en `InventarioService`.
  - Modelos en carpeta `Models/`.

- **Interfaz simple:**  
  - Menú interactivo por consola.
 
¿Cómo Ejecutar y Probar?
1. Instala .NET 8 SDK.
2. Abre consola en el proyecto.
3. Ejecuta: `dotnet run`
4. Prueba las operaciones desde el menú.

## Ejemplo de Ejecución

Bienvenido al Sistema de Gestión de Inventario Lectura Viva
1. Agregar libro
2. Consultar libros
3. Actualizar libro
4. Eliminar libro
5. Registrar venta
6. Ver reportes
0. Salir
Seleccione opción: 


## Sugerencias de Mejora
- Persistencia de datos en archivos o base de datos.
- Multiusuario y autenticación.
- Más reportes y filtros avanzados.

## Estructura de Carpetas

InventarioLibreria/
├── Program.cs
├── Models/
│   ├── Producto.cs
│   ├── Libro.cs
│   └── Venta.cs
└── Services/
    └── InventarioService.cs

## Configuracion
### **Programa principal (menú de acciones):**
```csharp
class Program
{
    static void Main(string[] args)
    {
        // Instancia de InventarioService y menú interactivo
    }
}

```
##Recursos Adicionales

- [Documentación oficial .NET](https://learn.microsoft.com/es-es/dotnet/)
- [Guía C# POO](https://learn.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/object-oriented-programming)
- [Ejemplo de repositorio en GitHub](https://github.com/dotnet/samples/tree/main/csharp/getting-started/console-teleprompter)

Nota
Este ejemplo guía puede ser adaptado a otros negocios o ampliado con funcionalidades extra (usuarios, categorías, persistencia en archivos, etc.).

Autor:
Jorge Alexander Marin
ID: 25119011
Estudiante Ingenieria de sistemas
PND 2025-2


  

