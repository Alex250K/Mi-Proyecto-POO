
# Mi-Proyecto-POO
Gestion de Inventario Simple Para una Libreria

## 1. Caso de Negocio
La librería "Lectura Viva" necesita una aplicación interna para gestionar su inventario de libros. El sistema debe permitir agregar, consultar, actualizar y eliminar libros, registrar ventas y mostrar reportes básicos de stock y ventas.
Actualmente, la librería lleva el control de su inventario de libros y las ventas de forma manual (papel o Excel). Esto genera errores frecuentes, pérdida de información, dificultad para conocer el stock real, y falta de reportes para tomar decisiones rápidas.

## 2. Historias de Usuario

1. **Como encargado de la librería, quiero poder agregar nuevos libros al inventario para mantener actualizada la lista.**
2. **Como encargado, quiero consultar los libros disponibles en el inventario para saber qué tengo en stock.**
3. **Como encargado, quiero actualizar los datos de un libro (precio, cantidad, etc.) para reflejar cambios en el inventario.**
4. **Como encargado, quiero eliminar libros del inventario cuando ya no estén disponibles.**
5. **Como vendedor, quiero registrar la venta de un libro para descontar el stock y contabilizar ingresos.**
6. **Como gerente, quiero ver reportes de ventas y stock para tomar decisiones de compra.**

**Ejemplo de dolor:**
- Se vende un libro que ya no está en stock.
- El encargado no sabe cuántos libros hay de cada título.
- No se registran todas las ventas, lo que causa diferencias en el dinero y el inventario.

## 2. Usuarios (¿quién usa la app?)

- **Operador:** Persona encargada de agregar, consultar, actualizar y eliminar libros; registrar ventas.
- **Supervisor o gerente:** Persona que consulta los reportes de inventario y ventas para tomar decisiones de compra o reposición.

## 3. Valor (¿qué mejora concreta entregará?)

- **Control automático y confiable del inventario de libros.**
- **Registro seguro de ventas y actualización automática de stock.**
- **Reportes rápidos y claros para tomar decisiones (qué libros comprar, cuáles se venden más, etc.).**
- **Menos errores humanos y mayor eficiencia en la gestión diaria.**
- **Historial básico de ventas para análisis futuro.**

## Decisiones de diseño

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

  **Persistencia:**  
  - No implementada para mantener la simplicidad. Se puede agregar con archivos o base de datos.

  ## ¿Cómo probar?
  Ejemplo de flujo típico:
  Bienvenido al Sistema de Inventario Lectura Viva
1. Agregar libro
2. Consultar libros
3. Actualizar libro
4. Eliminar libro
5. Registrar venta
6. Ver reportes
0. Salir
Seleccione opción: 1
Título: El Quijote
Autor: Miguel de Cervantes
ISBN: 9788491050611
Precio: 350
Stock: 10
Libro agregado exitosamente.

Seleccione opción: 2

Libros en inventario:
El Quijote - Miguel de Cervantes | ISBN: 9788491050611 | Stock: 10 | Precio: $350.00

Seleccione opción: 5
Ingrese ISBN del libro vendido: 9788491050611
Cantidad vendida: 2
Venta registrada correctamente.

Seleccione opción: 6

--- Reporte de Stock ---
El Quijote - Miguel de Cervantes | ISBN: 9788491050611 | Stock: 8 | Precio: $350.00

--- Reporte de Ventas ---
09/09/2025 12:13 | El Quijote | Cantidad: 2 | Total: $700.00

## Evidencias (simulaciones de consola)
1. Agregar libro
Título: C# Avanzado
Autor: Juan Pérez
ISBN: 123456789
Precio: 500
Stock: 5
Libro agregado exitosamente.
2. Consultar libros
C# Avanzado - Juan Pérez | ISBN: 123456789 | Stock: 5 | Precio: $500.0
3. Registrar venta
Ingrese ISBN del libro vendido: 123456789
Cantidad vendida: 1
Venta registrada correctamente.
6. Ver reportes: 
--- Reporte de Stock ---
C# Avanzado - Juan Pérez | ISBN: 123456789 | Stock: 4 | Precio: $500.00

--- Reporte de Ventas ---
09/09/2025 12:15 | C# Avanzado | Cantidad: 1 | Total: $500.00

## Sugerencias de mejora

- Persistencia de datos en archivos o base de datos.
- Multiusuario y autenticación.
- Más reportes y filtros avanzados.

## Ejemplo sintético
“La app ayudará a la librería a saber exactamente cuántos libros tiene, registrar todas las ventas al instante y ofrecer reportes claros para que el 
encargado o el gerente pueda reponer stock y evitar ventas erróneas.”

## Autor
Jorge Alexander Marin
https://github.com/Alex250K/Mi-Proyecto-POO/blob/82d38140934c240ad988053087d80ef04e59ecf1/README.md
