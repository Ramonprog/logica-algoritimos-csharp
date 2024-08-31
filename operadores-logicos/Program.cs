int number1 = 8;
int number2 = 3;

// E
Console.WriteLine(number1 > number2 && number1 < number2);

// OU
Console.WriteLine(number1 > number2 || number1 < number2);

// NÃO
Console.WriteLine(!true);


// condicionais simples
int idade = 29;

if (idade > 18)
{
    Console.WriteLine("Você é maior de idade");
}
else 
{
    Console.WriteLine("Você é menor de idade");
}

// condicional encadeada

double media = 6;

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >=5)
{
    Console.WriteLine("Em exame");
}
else 
{
    Console.WriteLine("Reprovado");
}

//  ternário
Console.WriteLine(media >= 7 ? "Aprovado" : "Reprovado");