using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using proyectoinvestigacion.API.Data;
using proyectoinvestigacion.Shared.Entidades;

namespace proyectoinvestigacion.API.Controllers
{
    [ApiController]
    [Route("api/Proyecto")]
    public class ProyectoControlador : ControllerBase
    {
        private readonly DataContext _context;

        public ProyectoControlador(DataContext context)
        {
            _context = context;
        }

        // get por lista
       
        [HttpGet]

        public async Task<ActionResult> Get(int id)
        {

          
            var proyecto = await _context.Proyectos.FirstOrDefaultAsync(x => x.Id == id);

            if (proyecto == null)
            {
                return NotFound();
            }

            return Ok(proyecto);
        }


        //insertar un resgistro

        [HttpPost]
        public async Task<ActionResult> Post(Proyecto proyecto)
        {
            _context.Add(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto);

        }
    }
}

    

