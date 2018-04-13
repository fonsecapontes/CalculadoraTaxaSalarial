using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public class CalcularTaxaSalarialTerceiraStrategy : ICalcularTaxaSalarialStrategy
    {
        private const double _minSalario = 5000.00;
        private const double _maxSalario = 7000.00;
        private const double _porcentagem = 15;
        private const double _porcentagemCalculo = 0.15;

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
