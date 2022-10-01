int n1, n2;

Console.WriteLine("Divisão de dois numeros");

Console.Write("Digite o primeiro numero: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o primeiro numero: ");
n2 = Convert.ToInt32(Console.ReadLine());


if (n2 == 0)
{
    Console.WriteLine("Não é possivel dividir por zero.");
}
else
{
    double resultado = n1 / n2;
    Console.WriteLine($"{n1} dividido por {n2} é {resultado}");
}