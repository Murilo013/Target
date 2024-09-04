
namespace codigo;

class Program {

    //Ex 1 -------------------------------------
    static string ex1Fibonacci()
    {
        Console.WriteLine("----- Ex 01 -----");
        int valor;
        do
        {
            Console.Write("Insira um valor para a verificação: ");
        } while (!int.TryParse(Console.ReadLine(), out valor));

        int a = 0, b = 1, c = 0;
        bool loop = true;
        while (loop)
        {
            if (valor == c)
            {
                return $"O número {valor} pertence a sequencia";
            }
            else
            {
                if (valor > c)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                else
                {
                    loop = false;
                }
            }
        }
        return $"O número {valor} não pertence a sequencia";
    }

    //Ex 2 -------------------------------------
    static int ex2Verificacao()
    {
        Console.WriteLine("Escreva algo:");
        string txt = Console.ReadLine().ToLower();

        int quantidade = txt.Count(a => a == 'a');
        return quantidade;

    }

    static void Main(string[] args)
    {
        Console.WriteLine(ex1Fibonacci());
        Console.WriteLine("Existem " + ex2Verificacao() + " letras 'a'.");
        Console.ReadKey();

        int INDICE = 12, SOMA = 0, K = 1; 
        while (K < INDICE)
        { K = K + 1; SOMA = SOMA + K; } 
        Console.WriteLine(SOMA);
    }
}

