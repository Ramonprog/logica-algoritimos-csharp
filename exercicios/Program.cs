// 01 2 numeros inteiros, se iguais soma senao multiplica

// Console.WriteLine("Digite um numero inteiro: ");
// int number01 = int.Parse(Console.ReadLine());

// pode se usar Convert.ToInt16(Console.ReadLine())

// Console.WriteLine("Digite outro numero inteiro: ");
// int number02 = int.Parse(Console.ReadLine());

// int res = number01 == number02 ? number01 + number02 : number01 * number02;

// Console.WriteLine("Resultado: " + res);


// 02 pegue um numero e veja se é par ou ímpar

Console.WriteLine("Digite um numero inteiro: ");
int number01 = int.Parse(Console.ReadLine());

string res = number01 % 2 == 0 ? "par" : "ímpar";
Console.WriteLine(res);