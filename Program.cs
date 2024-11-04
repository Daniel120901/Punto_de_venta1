using System;
using System.Collections.Generic;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    public Producto(int id, string nombre, double precio, int cantidad)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }
}

public class Carrito
{
    private List<Producto> productos;

    public Carrito()
    {
        productos = new List<Producto>();
    }

    // Método para agregar un producto al carrito
    public void AgregarProducto(Producto producto)
    {
        // Verifica si el producto ya está en el carrito
        var productoExistente = productos.Find(p => p.Id == producto.Id);
        if (productoExistente != null)
        {
            // Si ya existe, aumentar la cantidad
            productoExistente.Cantidad += producto.Cantidad;
        }
        else
        {
            // Si no existe, agregarlo a la lista
            productos.Add(producto);
        }
    }

    // Método para eliminar un producto del carrito
    public void EliminarProducto(int productoId)
    {
        var producto = productos.Find(p => p.Id == productoId);
        if (producto != null)
        {
            productos.Remove(producto);
        }
    }

    // Método para calcular el total del carrito
    public double CalcularTotal()
    {
        double total = 0;
        foreach (var producto in productos)
        {
            total += producto.Precio * producto.Cantidad;
        }
        return total;
    }

    // Método para mostrar los productos en el carrito
    public void MostrarProductos()
    {
        Console.WriteLine("Productos en el carrito:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"- {producto.Nombre}: {producto.Cantidad} x ${producto.Precio:F2} = ${producto.Precio * producto.Cantidad:F2}");
        }
    }
}