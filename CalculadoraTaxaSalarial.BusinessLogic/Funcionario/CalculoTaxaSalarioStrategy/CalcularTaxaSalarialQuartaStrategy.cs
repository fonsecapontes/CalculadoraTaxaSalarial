using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public class CalcularTaxaSalarialQuartaStrategy : ICalcularTaxaSalarialStrategy
    {
        private const double _minSalario = 7000.00;
        private const double _porcentagem = 25;
        private const double _porcentagemCalculo = 0.25;

        public Funcionario Calcular(Funcionario funcionario)
        {
            if (!IsSatisfaz(funcionario.SalarioBruto)) { return new Funcionario(); }

            funcionario.PorcentagemImposto = _porcentagem;
            funcionario.ValorImpostoPago = funcionario.SalarioBruto * _porcentagemCalculo;
            funcionario.SalarioLiquido = funcionario.SalarioBruto - funcionario.ValorImpostoPago;

            return funcionario;
        }

        public bool IsSatisfaz(double salario)
        {
            return salario >= _minSalario;
        }
    }
}
