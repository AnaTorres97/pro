using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacion.API.Data;
using ProyectoInvestigacion.Shared.Entidades;

namespace ProyectoInvestigacion.API.Controllers
{
    [ApiController]
    [Route("api/investigadores")]
    public class InvestigadoresControlador : ControllerBase
    {
        private readonly DataContext _context;


        public InvestigadoresControlador(DataContext context)
        {
            _context = context;
        }


        // get por lista
        //select * from owners
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            //200 Ok

            return Ok(await _context.Investigadores.ToListAsync());
        }


        // get por parametro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var investigador = await _context.Investigadores.FirstOrDefaultAsync(x => x.Id == id);

            if (investigador == null)
            {
                return NotFound();
            }

            return Ok(investigador);
        }


        //insertar un resgistro
        [HttpPost]
        public async Task<ActionResult> Post(Investigador investigador)
        {
            _context.Add(investigador);
            await _context.SaveChangesAsync();
            return Ok(investigador);

        }
    }
}
