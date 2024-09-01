string language = "Java";

switch (language)
{
    case "C#":
        Console.WriteLine("Olá mundo do C#");
        break;
    case "Java":
        Console.WriteLine("Olá mundo do Java");
        break;
    case "Python":
        Console.WriteLine("Olá mundo do Python");
        break;
    default:
        Console.WriteLine("Não conheço esse idioma");
        break;
}

// expressao switch

string retorno = language switch
{
    "C#" => "Olá mundo do C#",
    "Java" => "Olá mundo do Java",
    "Python" => "Olá mundo do Python",
    _ => "Não conheço esse idioma"
};

Console.WriteLine("retorno: " + retorno);

// while "enquanto"

int indice = 1;

while (indice < 10)
{
    Console.WriteLine(indice);
    indice++;
}


// do while

do
{
  Console.WriteLine(indice + "do while");
  indice++;
}
while(indice <= 10);

// for

for (int i = 1; i <= 10; i++)
{
  Console.WriteLine(i + "for");
}

// vetor

string[] names = ["Alisson", "Rafael", "João", "Pedro"];

//foreach

foreach (string name in names)
{
    Console.WriteLine(name);
}