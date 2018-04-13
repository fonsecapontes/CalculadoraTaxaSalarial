using CalculadoraTaxaSalarial.Model;
using System.Collections.Generic;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public class FuncionarioBll : IFuncionarioBll
    {
        public Funcionario CalcularTaxaSalarial(Funcionario funcionario)
        {
            if (funcionario == null) { return new Funcionario(); }

            var strategies = new List<ICalcularTaxaSalarialStrategy>
            {
                new CalcularTaxaSalarialPrimeiraStrategy(),
                new CalcularTaxaSalarialSegundaStrategy(),
                new CalcularTaxaSalarialTerceiraStrategy(),
                new CalcularTaxaSalarialQuartaStrategy(),
            };

            foreach (var strategy in strategies)
            {
                if (!strategy.IsSatisfaz(funcionario.SalarioBruto)) continue;

                funcionario = strategy.Calcular(funcionario);
                break;
            }

            return funcionario;            
        }
    }
}
