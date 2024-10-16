DateTime startTime = new DateTime(1981,3,3);
//int age = DateTime.Now.Year - startTime.Year;
Console.WriteLine($"Digite sua idade:");

int age = Convert.ToInt32(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine($"menor de idade, REPROVADO.");
    
}else if (age >= 65)
{
    Console.WriteLine($"não pode ser aprovado, idade avançada");
    
}else
{
    Console.WriteLine($"idade aprovada!");
    
}

Console.WriteLine($"idade é {age.ToString()}");
