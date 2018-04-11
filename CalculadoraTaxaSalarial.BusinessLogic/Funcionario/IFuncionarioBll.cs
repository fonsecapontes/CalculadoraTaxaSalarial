using CalculadoraTaxaSalarial.Model;

namespace CalculadoraTaxaSalarial.BusinessLogic
{
    public interface IFuncionarioBll
    {
        string CalcularTaxa(Funcionario funcionario);
    }
}
