using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public class CalcularTaxaSalarialPrimeiraStrategy : ICalcularTaxaSalarialStrategy
    {
        private const double _maxSalario = 3000.00;

        public Funcionario Calcular(Funcionario funcionario)
        {
            if (!IsSatisfaz(funcionario.SalarioBruto)) { return new Funcionario(); }
            
            funcionario.SalarioLiquido = funcionario.SalarioBruto - funcionario.ValorImpostoPago;

            return funcionario;
        }

        public bool IsSatisfaz(double salario)
        {
            return salario < _maxSalario;
        }
    }
}
