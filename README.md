# **Sistema de Punto de Venta (POS)**

<p align="center">
Este proyecto es un sistema de punto de venta (POS) simple, diseñado para gestionar productos, realizar ventas y llevar un registro de cada transacción. La aplicación cuenta con funcionalidades para agregar productos a un carrito de compras, procesar una venta, y generar un resumen o ticket de la transacción.
</p>

## **Características**

- **Gestión de Productos**: Agrega, elimina y actualiza productos disponibles.
- **Carrito de Compras**: Permite agregar productos al carrito en distintas cantidades.
- **Procesamiento de Ventas**: Calcula el total de cada venta, registra la fecha y genera un ticket.
- **Reporte de Ventas**: Proporciona un resumen de las ventas realizadas.

## **Estructura del Proyecto**
El proyecto sigue una estructura de clases para organizar las funcionalidades:

- **`Producto`**: Representa un producto con sus detalles, como nombre, precio y cantidad en inventario.
- **`Carrito`**: Maneja una lista de productos añadidos por el cliente.
- **`Venta`**: Representa una transacción de venta e incluye el carrito, el total y la fecha de la venta.
- **`VentaControlador`**: Coordina la lógica de negocio, administra el carrito y procesa las ventas.
