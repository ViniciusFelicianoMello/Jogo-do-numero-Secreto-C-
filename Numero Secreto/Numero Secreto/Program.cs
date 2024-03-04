Console.WriteLine(@"
█▄░█ █░█ █▀▄▀█ █▀▀ █▀█ █▀█   █▀▄ ▄▀█   █▀ █▀█ █▀█ ▀█▀ █▀▀
█░▀█ █▄█ █░▀░█ ██▄ █▀▄ █▄█   █▄▀ █▀█   ▄█ █▄█ █▀▄ ░█░ ██▄");
Console.WriteLine("\nBem vindo ao jogo");

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 100);
int numeroMinimo = 1;
int numeroMaximo = 100;

int tentativas = 0;

do{
    Console.Write("\nDigite um numero entre " + numeroMinimo + " e " + numeroMaximo + ": ");
    int chute = int.Parse(Console.ReadLine());

    tentativas++;
    if(chute == numeroSecreto)
    {
        string palavraTentativa = tentativas > 1 ? "tentativas" : "tentativa";
        string mensagemTentativas = $"`Parabens, você descobriu o número secreto com {tentativas} {palavraTentativa}" ;

        Console.WriteLine(mensagemTentativas);
    break;
    } else if(chute < numeroSecreto)
    {
        Console.WriteLine("O numero é maior que o chute.");
    } else 
    {
        Console.WriteLine("O numero é menor que o chute");
    }
    

} while(true);