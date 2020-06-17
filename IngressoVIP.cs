namespace Dojo_2
{
    public class IngressoVIP : Ingresso
    {
        public float valorAdicional { get; set;}

        public void ImprimirValorVIP(){
            float ValorIngressoVIP = valor + valorAdicional;

            System.Console.WriteLine("Preço Ingresso VIP: {0:c}",ValorIngressoVIP);

            System.Console.WriteLine("--------------------------------");

            System.Console.WriteLine("A diferença de valor entre o ingresso normal e o VIP é: {0:c}",valorAdicional);
        }
    }
}