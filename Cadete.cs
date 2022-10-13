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
}

