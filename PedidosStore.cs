public class PedidosStore{

    private List<Pedido> _pedidos = new List<Pedido>();

    public void Agregar(Pedido pedido){
        _pedidos.Add(pedido);
    }

    public List<Pedido> ObtenerTodos(){
        return _pedidos;
    }

}