using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public class CalcularTaxaSalarialSegundaStrategy : ICalcularTaxaSalarialStrategy
    {
        private const double _minSalario = 3000.00;
        private const double _maxSalario = 5000.00;
        private const double _porcentagem = 10;
        private const double _porcentagemCalculo = 0.1;

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
            return salario >= _minSalario && salario < _maxSalario;
        }
    }
}
