using CalculadoraTaxaSalarial.BusinessLogic;
using CalculadoraTaxaSalarial.Model;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraTaxaSalarial.Application.Controllers
{
    [Route("api/[controller]")]
    public class CalcularTaxaSalarialController : Controller
    {
        private readonly IFuncionarioBll _funcionarioBll;

        public CalcularTaxaSalarialController(IFuncionarioBll funcionarioBll)
        {
            _funcionarioBll = funcionarioBll;
        }        

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Funcionario funcionario)
        {
            return Json(_funcionarioBll.CalcularTaxaSalarial(funcionario));
        }        
    }
}
