// See https://aka.ms/new-console-template for more information
public class Cadeteria 
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadetes;

    public Cadeteria(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.listaCadetes = new List<Cadete>();
    }

    public void agregarCadete(Cadete nuevo)
    {
        listaCadetes.Add(nuevo);
    }

    public void asignarPedidoACadete(Pedido pedido, int idCadete){
        bool bandera= true;
        foreach (var repartidor in this.listaCadetes)
        {
            if (repartidor.Id== idCadete)
            {
                repartidor.agregarPedido(pedido);
                bandera= false;
            }
        }
        if (!bandera)
        {
            System.Console.WriteLine("El pedido se asignó correctamente");
        } else
        {
            System.Console.WriteLine("No se pudo agregar el pedido al cadete");
        }
    }

    public void removerPedidoDeCadete(Pedido pedido, int idCadete){
        bool bandera= true;
        foreach (var repartidor in this.listaCadetes)
        {
            if (repartidor.Id == idCadete)
            {
                repartidor.eliminarPedido(pedido);
            }
        }
        if (!bandera)
        {
            System.Console.WriteLine("El pedido se elimino correctamente");
        } else
        {
            System.Console.WriteLine("No se pudo eliminar el pedido al cadete");
        }
    }

    public void cambiarPedidoDeCadete(Pedido pedido, int idCadeteEntrega, int idCadeteNoEntrega){
        foreach (var repartidor in listaCadetes)
        {
            
        }
    }
}