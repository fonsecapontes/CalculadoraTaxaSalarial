namespace CalculadoraTaxaSalarial.Model
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBruto { get; set; }
        public double? SalarioLiquido { get; set; }
        public double ValorImpostoPago { get; set; }
        public double? PorcentagemImposto { get; set; }
    }
}
