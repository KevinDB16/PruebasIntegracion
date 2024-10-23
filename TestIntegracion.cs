public class TestIntegracion{
     
     private GestionPedidos _gestionPedidos;
     private PedidosStore _store;

     [SetUp]
     public void SetUp(){
        _store = new PedidosStore();
        _gestionPedidos = new GestionPedidos(_store);      
     }

     [Test]
     public void AgregarPedidoIntegracion(){
        var producto1 = new Producto(1, "Lavarropas", 100.00m);
        var producto2 = new Producto(2, "Heladera", 50.00m);

        var pedido = new Pedido();
        pedido.AgregarProducto(producto1);
        pedido.AgregarProducto(producto2);

        _gestionPedidos.AgregarPedido(pedido);

        var pedidos = _gestionPedidos.ObtenerPedidos();

        Assert.That(pedidos.Count, Is.EqualTo(1), "La cantidad de pedidos no fue 1");
        Assert.That(pedidos[0].CalcularTotal(), Is.EqualTo(150.00m), "El precio no fue 150");
     }

}