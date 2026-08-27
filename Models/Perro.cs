namespace TP_API;
public class Perro : Mascota

{
    private string raza;

    public string Raza {get { return raza;} set { raza = value; }}

    public Perro(int id, string nombre, int edad, string raza) : base(id, nombre, edad)
    {
        this.Raza = raza;
    }

}