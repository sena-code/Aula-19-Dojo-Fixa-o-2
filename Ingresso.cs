namespace Aula18Dojo
{
    public class Ingresso
    {
        public float Valor {get; set; }
        public void ImprimirValor(){
            System.Console.WriteLine($"O valor do ingresso comum é {Valor}.");
        }
    }
}