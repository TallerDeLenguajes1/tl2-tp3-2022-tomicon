// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cadeteria pedidosAhora= new Cadeteria("pedidosAhora","381333444");

pedidosAhora.agregarCadete(1,"tomi","por ahi", "3812225555");
pedidosAhora.agregarCadete(2,"fran","por alla", "3812225556");

Pedido pedido1= new Pedido(23,"por aca", Estados.porSalir, 2, "javier", "el cerrito", "3811112345", "no hay datos");

pedidosAhora.asignarPedidoACadete(pedido1, 1);
pedidosAhora.cambiarPedidoDeCadete(pedido1, 2, 1);
pedidosAhora.cadeteComenzoEntrega(2, pedido1);
pedidosAhora.cadeteRealizoEntrega(2, pedido1);
double totalCadete2= pedidosAhora.calcularJornalCadete(2);
System.Console.WriteLine($"El monto total es: ${totalCadete2}");
