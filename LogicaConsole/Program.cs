using System;

namespace LogicaConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome da fruta que você quer comprar?");
            string fruta = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{fruta}, OK! e quantas você quer?");
            Double quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Ok! Aqui estão suas {quantidade} {fruta}s");
            Console.Clear();
            int itemValor = 2;
            var pagamento = 0;
            var total = quantidade * itemValor;
            var troco = total - pagamento;
            Console.WriteLine($"OK! O total vai te custar: R${total},00 o senhor vai me dar quanto em dinheiro?");
            pagamento = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Muito obrigado aqui está seu troco de R$ {troco},00");
            
        }
    }
}
