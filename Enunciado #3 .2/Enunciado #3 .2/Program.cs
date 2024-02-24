Random random = new Random();
int numeroAleatorio = random.Next(1, 101);

int numeroUsuario;

do
{
    Console.WriteLine("Escriba un número del 1 al 100: ");
    numeroUsuario = int.Parse(Console.ReadLine());

    if (numeroUsuario > numeroAleatorio)
    {
        Console.WriteLine("Te equivocoaste el número es menor.");
    }
    else if (numeroUsuario < numeroAleatorio)
    {
        Console.WriteLine("Te equivocaste el número es mayor.");
    }
    
} while (numeroUsuario != numeroAleatorio);

Console.WriteLine("Adivinaste");
