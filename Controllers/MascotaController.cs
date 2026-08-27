using Microsoft.AspNetCore.Mvc;

namespace TP_API;

[ApiController]
[Route("[controller]")]
public class MascotaController : ControllerBase
{
    private static List<Mascota> ListMascotas = new List<Mascota>
        {
            new Perro{Id = 1, Nombre = "Firulais", Edad = 5, Raza = "Labrador"},
            new Gato {Id = 2, Nombre = "Luna",Edad = 3, Color = "Blanco"},
            new Perro{Id = 3,Nombre = "Rocky",Edad = 8,Raza = "Pastor Alemán" },
            new Gato {Id = 4,Nombre = "Michi",Edad = 10, Color = "Negro"}
        };
    private readonly ILogger<MascotaController> _logger;

    public MascotaController(ILogger<MascotaController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(ListMascotas);
    }

    [HttpGet("{Id}")]
    public IActionResult ObtenerPorId(int Id)
    {
        foreach (Mascota m in ListMascotas)
        {
            if (m.Id == Id)
            {
                return Ok(m);
            }
        }

        return NotFound("Mascota no encontrada");
    }

    [HttpPost("perro")]
    public IActionResult CrearPerro([FromBody] Perro nuevoPerro)
    {
        ListMascotas.Add(nuevoPerro);

        return Ok("Perro creado con exito");
    }

    [HttpPost("gato")]
    public IActionResult CrearGato([FromBody] Gato nuevoGato)
    {
        ListMascotas.Add(nuevoGato);

        return Ok("Gato creado con exito");
    }


    [HttpPut("{Id}")]
    public IActionResult Update(int Id, [FromBody] Mascota MascotaActualizada)
    {
        foreach (Mascota mascota in ListMascotas)
        {
            if (mascota.Id == Id)
            {
                mascota.Nombre = MascotaActualizada.Nombre;
                mascota.Edad = MascotaActualizada.Edad;

                return Ok("Mascota actualizada con exito");
            }
        }

        return NotFound("Mascota no encontrada");
    }
    

    [HttpDelete("{Id}")]
    public IActionResult Delete(int Id)
    {
        for (int i = 0; i < ListMascotas.Count; i++)
        {
            if (ListMascotas[i].Id == Id)
            {
                ListMascotas.RemoveAt(i);
                return Ok("Mascota eliminada correctamente");
            }
        }

        return NotFound("Mascota no encontrada");
    }


    [HttpGet("mayores-a/{edad}")]
    public IActionResult MayoresA(int edad)
    {
        List<Mascota> mascotasMayores = new List<Mascota>();

        foreach (Mascota mascota in ListMascotas)
        {
            if (mascota.Edad > edad)
            {
                mascotasMayores.Add(mascota);
            }
        }

        return Ok(mascotasMayores);
    }


    [HttpGet("tipo/{tipo}")]
    public IActionResult PorTipo(string tipo)
    {
        List<Mascota> mascotasTipo = new List<Mascota>();

        foreach (Mascota mascota in ListMascotas)
        {
            if (tipo == "perro" && mascota is Perro)
            {
                mascotasTipo.Add(mascota);
            }

            if (tipo == "gato" && mascota is Gato)
            {
                mascotasTipo.Add(mascota);
            }
        }

        return Ok(mascotasTipo);
    }
}