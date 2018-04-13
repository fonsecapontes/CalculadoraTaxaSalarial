using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public interface ICalcularTaxaSalarialStrategy
    {
        Funcionario Calcular(Funcionario funcionario);

        bool IsSatisfaz(double salario);
    }
}
