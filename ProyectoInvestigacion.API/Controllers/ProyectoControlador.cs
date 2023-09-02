using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacion.API.Data;
using ProyectoInvestigacion.Shared.Entidades;

namespace ProyectoInvestigacion.API.Controllers
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

        public async Task<ActionResult> Get()
        {

            //200 Ok

            return Ok(await _context.Proyectos.ToListAsync());
        }

        // get por parametro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

             
            var proyecto = await _context.Investigadores.FirstOrDefaultAsync(x => x.Id == id);

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
