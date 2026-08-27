using System;
namespace TP_API;
public abstract class Mascota
{
    private int id ;
    private string nombre;
    private int edad;
    public int Id {get { return id;} set { id = value; }}
    public string Nombre {get { return nombre;} set { nombre = value; }}
    public int Edad {get { return edad;} set { edad = value; }}

    
}