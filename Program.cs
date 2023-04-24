// Receba um número. Exiba "par" ou "ímpar", conforme o caso.
Console.WriteLine("--- Par ou Ímpar ---");

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine()!);

if (numero % 2 == 0) {
    Console.WriteLine("par");
} else {
    Console.WriteLine("ímpar");
}