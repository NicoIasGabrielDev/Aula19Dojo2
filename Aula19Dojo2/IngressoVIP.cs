namespace Aula19Dojo2
{
    internal class IngressoVip
    {
    }
}namespace Aula19Dojo2
{
    public class IngressoVIP:Ingresso
    {
        public float ValorAdicional { get; set; }

        public void ValorVip()
        {
            float diferenca = Valor + ValorAdicional;
            System.Console.WriteLine($"Valor do ingresso adicional é R$ {diferenca}");
        }
    }
}