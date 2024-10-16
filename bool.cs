// See https://aka.ms/new-console-template for more information
int age = 41;

bool a = (age == 41);
Console.WriteLine($"a idade é igual a 41? " + a);//true

bool b = (age != 41);
Console.WriteLine($"a idade é diferente a 41? " + b);//false

bool c = (age > 41);
Console.WriteLine($"a idade é maior a 41? " + c);//false

bool d = (age < 41);
Console.WriteLine($"a idade é menor a 41? " + d);//false

bool e = (age >= 41) && (age <= 50);
Console.WriteLine($"a idade é maior que 41 e menor que 50? " + e);//true

bool f = (age >= 41) || (age <= 50);
Console.WriteLine($"a idade é maior que 41 ou menor que 50? " + f);//true
