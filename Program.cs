double idade;
Console.WriteLine("Por Favor digite sua idade");
idade = Convert.ToDouble(Console.ReadLine());

if (idade > 67)
{
    Console.WriteLine("Você não pode ser doador de sangue.");
}
else if (idade < 18)
{
    Console.WriteLine("Você não pode ser doador de sangue.");
}
else if (idade < 67)
{
    Console.WriteLine("Você pode ser doador de sangue.");
}
else if (idade > 18)
{
    Console.WriteLine("Você pode ser doador de sangue.");
}