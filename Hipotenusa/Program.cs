double cateto1, cateto2, hipotenusa;

Console.WriteLine("Digite o valor do primeiro cateto");
cateto1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do primeiro cateto");
cateto2 = double.Parse(Console.ReadLine());

if (cateto1 > 0 && cateto1 > 0)
{
    hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

    Console.WriteLine("A hipotenusa é: " + hipotenusa);
}
else
    Console.WriteLine("Um dos valores digitados é inválido. Tente novamente...");

Console.WriteLine("Digite Enter para encerrar...");

Console.ReadLine();