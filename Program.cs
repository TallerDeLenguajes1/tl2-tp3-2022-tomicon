// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cadeteria pedidosAhora= new Cadeteria("pedidosAhora","381333444");
List<Pedido> listaPedidos= new List<Pedido>();
foreach(var linea in File.ReadAllLines("Cadetes.csv"))
{
    if(linea != "")
    {
        var informacion = linea.Split(";");
        pedidosAhora.agregarCadete(Int32.Parse(informacion[0]), informacion[1], informacion[2], informacion[3]);
    }
}
foreach(var linea in File.ReadAllLines("Pedidos.csv"))
{
    if(linea != "")
    {
        var informacion = linea.Split(";");
        Pedido nuevo = new Pedido(Int32.Parse(informacion[0]), informacion[1], Estados.porSalir, Int32.Parse(informacion[2]), informacion[3], informacion[4], informacion[5], informacion[6]);
        listaPedidos.Add(nuevo);
    }
}
int opcion= 1;
int numPedido=0;
int cadeteEntrega=0;
int cadeteNoEntrega=0;
int estado=0;
Pedido pedido;
do
{
    System.Console.WriteLine("\n\n||----Menu pricipal----||\n");
    System.Console.WriteLine("Seleccione una opcion:");
    System.Console.WriteLine("0= terminar programa");
    System.Console.WriteLine("1= asignar pedido a cadete");
    System.Console.WriteLine("2= cambiar un pedido de cadete");
    System.Console.WriteLine("3= cambiar pedido de estado");
    System.Console.WriteLine("4= mostrar informe final");
    opcion= Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 0:
            break;
        case 1: 
            System.Console.WriteLine("Ingrese el numero de pedido:");
            numPedido= Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingrese el numero del Cadete");
            cadeteEntrega= Convert.ToInt32(Console.ReadLine());
            pedidosAhora.asignarPedidoACadete(listaPedidos[numPedido],cadeteEntrega);
            break;
        case 2:
            System.Console.WriteLine("Ingrese el id del cadete que entregara el pedido");
            cadeteEntrega= Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingrese el nro de pedido");
            numPedido= Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("ingrese el id del cadete que tenia asignado el pedido antes del cambio");
            cadeteNoEntrega= Convert.ToInt32(Console.ReadLine());
            pedidosAhora.cambiarPedidoDeCadete(listaPedidos[numPedido],cadeteEntrega,cadeteNoEntrega);
            break;
        case 3:
            System.Console.WriteLine("ingrese el nro de pedido");
            numPedido= Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("ingrese el id del cadete que realiza la entrega");
            cadeteEntrega= Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("A que estado quiere cambiar? (1= En camino, 2= entregado)");
            estado= Convert.ToInt32(Console.ReadLine());
            if (estado == 1)
            {
                pedidosAhora.cadeteComenzoEntrega(cadeteEntrega,listaPedidos[numPedido]);
            } else if (estado== 2)
            {
                pedidosAhora.cadeteRealizoEntrega(cadeteEntrega,listaPedidos[numPedido]);
            } else
            {
                System.Console.WriteLine("Opcion no valida, no se realizo el cambio");
            }
            break;
        case 4:
            pedidosAhora.mostrarInforme();
            break;
        default:
            System.Console.WriteLine("opcion no valida");
            break;
    }
} while (opcion != 0);

System.Console.WriteLine("\n||----Fin del programa---||");


// pedidosAhora.agregarCadete(1,"tomi","por ahi", "3812225555");
// pedidosAhora.agregarCadete(2,"fran","por alla", "3812225556");

// Pedido pedido1= new Pedido(23,"por aca", Estados.porSalir, 2, "javier", "el cerrito", "3811112345", "no hay datos");

// pedidosAhora.asignarPedidoACadete(pedido1, 1);
// pedidosAhora.cambiarPedidoDeCadete(pedido1, 2, 1);
// pedidosAhora.cadeteComenzoEntrega(2, pedido1);
// pedidosAhora.cadeteRealizoEntrega(2, pedido1);
// double totalCadete2= pedidosAhora.calcularJornalCadete(2);
// System.Console.WriteLine($"El monto total es: ${totalCadete2}");
