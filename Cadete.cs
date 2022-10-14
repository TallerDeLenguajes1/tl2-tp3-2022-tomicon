// See https://aka.ms/new-console-template for more information
public class Cadete : Persona
{
    private List<Pedido> ListadoPedidos;

    public Cadete(int id, string nombre, string direccion, string telefono) : base(id, nombre, direccion, telefono)
    {
        ListadoPedidos= new List<Pedido>();
    }

    public void agregarPedido(Pedido nuevo){
        ListadoPedidos.Add(nuevo);
    }

    public void eliminarPedido(Pedido pedidoAEliminar){
        if (this.ListadoPedidos.Remove(pedidoAEliminar))
        {
            System.Console.WriteLine("Exito al eliminar el pedido");
        } else
        {
            System.Console.WriteLine("no se pudo eliminar el pedido");
        }
        
    }

    public void comenzarEntrega(Pedido pedido){
        foreach (var encargo in this.ListadoPedidos)
        {
            if (encargo== pedido)
            {
                encargo.cambiarEstado(Estados.enCamino);
            }
        }
    }

    public void entregarPedido(Pedido pedido){
        foreach (var encargo in this.ListadoPedidos)
        {
            if (encargo== pedido)
            {
                encargo.cambiarEstado(Estados.entregado);
            }
        }
    }

    public double calcularJornal()
    {
        int canEntregados= 0;
        double pagoPorPedido= 300;
        foreach (var pedido in this.ListadoPedidos)
        {
            if (pedido.Estado== Estados.entregado)
            {
                canEntregados++;
            }
        }
        return pagoPorPedido * canEntregados;
    }
}

