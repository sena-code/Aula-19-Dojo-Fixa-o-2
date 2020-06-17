namespace Aula18Dojo
{
    public class IngressoVip : Ingresso 
    {
        public float ValorAdicional {get; set;}
        public void ImprimirValorAdicional(){
            float ValorVip = Valor + ValorAdicional;
            System.Console.WriteLine($"O valor do Ingresso Vip é {ValorVip}");
        }
    }
}