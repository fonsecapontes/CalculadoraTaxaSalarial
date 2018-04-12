using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public interface IFuncionarioBll
    {
        Funcionario CalcularTaxa(Funcionario funcionario);
    }
}
