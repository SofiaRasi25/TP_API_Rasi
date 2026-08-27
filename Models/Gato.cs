namespace TP_API;
public class Gato : Mascota

{
    private string color;

    public string Color {get { return color;} set { color = value; }}

    public Gato(int id, string nombre, int edad, string color) : base(id, nombre, edad)
    {
        this.Color = color;
    }

}