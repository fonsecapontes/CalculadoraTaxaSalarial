using CalculadoraTaxaSalarial.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraTaxaSalarial.Application.Controllers
{
    [Route("api/[controller]")]
    public class CalcularController : Controller
    {
        private readonly IFuncionarioBll _funcionarioBll;

        public CalcularController(IFuncionarioBll funcionarioBll)
        {
            _funcionarioBll = funcionarioBll;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _funcionarioBll.CalcularTaxa(new Model.Funcionario { });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }        
    }
}
