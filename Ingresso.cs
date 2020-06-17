namespace Dojo_2
{
    public class Ingresso
    {
        public float valor { get; set;}

        public void ImprimirValor(){
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("Preço Ingresso: {0:c}",valor);
    }
}