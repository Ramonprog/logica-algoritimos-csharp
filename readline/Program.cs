Console.WriteLine("Olá qual o seu nome?");

string ?name = Console.ReadLine();

Console.WriteLine($"{name} quantos anos voçê tem?");

int ?age = int.Parse(Console.ReadLine());

Console.WriteLine("Olá " + name + ", você tem " + age + " anos");

Console.WriteLine("Digite um número");
int number = Convert.ToInt16(Console.ReadLine());