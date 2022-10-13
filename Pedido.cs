// See https://aka.ms/new-console-template for more information
public class Pedido
{
    private int nro;
    private string obs;
    private Cliente usuario;
    private string estado;

    public Pedido(int nro, string obs, string estado, int id, string nombre, string direccion, string telefono, string datosDirec)
    {
        Nro = nro;
        Obs = obs;
        usuario = new Cliente(id, nombre, direccion, telefono, datosDirec);
        Estado = estado;
    }

    public string Estado { get => estado; set => estado = value; }
    public Cliente Usuario { get => usuario; set => usuario = value; }
    public string Obs { get => obs; set => obs = value; }
    public int Nro { get => nro; set => nro = value; }
    
}

