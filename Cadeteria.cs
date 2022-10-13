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
}