using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public class FuncionarioBll : IFuncionarioBll
    {
        public Funcionario CalcularTaxaSalarial(Funcionario funcionario)
        {
            if (funcionario == null) { return new Funcionario(); }

            if (funcionario.SalarioBruto < 3000.00)
            {
                funcionario.SalarioLiquido = funcionario.SalarioBruto;
            }
            else if (funcionario.SalarioBruto >= 3000.00 && funcionario.SalarioBruto < 5000.00)
            {
                funcionario.PorcentagemImposto = 10;
                funcionario.ValorImpostoPago = funcionario.SalarioBruto * 0.1;
            }
            else if (funcionario.SalarioBruto >= 5000.00 && funcionario.SalarioBruto < 7000.00)
            {
                funcionario.PorcentagemImposto = 15;
                funcionario.ValorImpostoPago = funcionario.SalarioBruto * 0.15;
            }
            else if (funcionario.SalarioBruto >= 7000.00)
            {
                funcionario.PorcentagemImposto = 25;
                funcionario.ValorImpostoPago = funcionario.SalarioBruto * 0.25;
            }

            funcionario.SalarioLiquido = funcionario.SalarioBruto - funcionario.ValorImpostoPago;

            return funcionario;
        }
    }
}
