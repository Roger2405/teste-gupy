//Função que executa a resolução do segundo exercício do teste
void sequenciaDeFibonacci()
{
    List<int> listaFibonacci = new List<int>() { 0, 1 };
    for (int i = 0; i < 20; i++)
    {
        int tamanhoDaLista = listaFibonacci.Count;
        int penultimoNumero = listaFibonacci[tamanhoDaLista - 1];
        int antepenultimoNumero = listaFibonacci[tamanhoDaLista - 2];
        int proximoNumero = penultimoNumero + antepenultimoNumero;
        listaFibonacci.Add(proximoNumero);
    }
    Console.WriteLine("Digite um número:");
    string entradaDoUsuario = Console.ReadLine();
    int numeroDaEntrada;

    if (int.TryParse(entradaDoUsuario, out numeroDaEntrada))
    {
        if (listaFibonacci.Contains(numeroDaEntrada))
        {
            Console.WriteLine("O número pertence à sequência de Fibonacci!");
        }
        else
        {
            Console.WriteLine("o número não pertence à sequência!");
        }
    }
    else
    {
        Console.WriteLine("Você deve digitar um número inteiro!");
    }
}

//Função que executa a resolução do quinto exercício do teste
void inverterString()
{
    Console.WriteLine("Digite uma string:");
    string entradaDoUsuario = Console.ReadLine();
    int tamanhoDaEntrada = entradaDoUsuario.Length;

    string novaString = "";

    for (int j = tamanhoDaEntrada - 1; j >= 0; j--)
    {
        novaString += entradaDoUsuario[j];
    }
    Console.WriteLine(novaString);
}
sequenciaDeFibonacci();
inverterString();