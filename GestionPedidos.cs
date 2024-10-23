public class GestionPedidos{
    private PedidosStore _store;

    public GestionPedidos(PedidosStore store){
        _store = store;
    }

    public void AgregarPedido(Pedido pedido){
        _store.Agregar(pedido);
    }

    public List<Pedido> ObtenerPedidos(){
        return _store.ObtenerTodos();
    }
}