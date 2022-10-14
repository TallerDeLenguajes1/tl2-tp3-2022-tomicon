// See https://aka.ms/new-console-template for more information

public enum Estados {entregado, enCamino, porSalir};
public class Pedido
{
    private int nro;
    private string obs;
    private Cliente usuario;
    private Estados estado;

    public Pedido(int nro, string obs, Estados estado, int id, string nombre, string direccion, string telefono, string datosDirec)
    {
        Nro = nro;
        Obs = obs;
        usuario = new Cliente(id, nombre, direccion, telefono, datosDirec);
        Estado = estado;
    }

    public Estados Estado { get => estado; set => estado = value; }
    public Cliente Usuario { get => usuario; set => usuario = value; }
    public string Obs { get => obs; set => obs = value; }
    public int Nro { get => nro; set => nro = value; }

    public void cambiarEstado(Estados nuevo){
        this.Estado= nuevo;
    }
    
}

