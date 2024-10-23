public class Producto
{
    public int Id { get; set;}
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Producto(int id, string nombre, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }
}
public class Pedido
{
    public int Id { get; set; }
    public List<Producto> Productos { get; set; } = new List<Producto>();
    
    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var producto in Productos)
        {
            total += producto.Precio;
        }
        return total;
    }
}