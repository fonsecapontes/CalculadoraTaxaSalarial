using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public interface IFuncionarioBll
    {
        Funcionario CalcularTaxaSalarial(Funcionario funcionario);
    }
}
