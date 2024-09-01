// 01 2 numeros inteiros, se iguais soma senao multiplica

// Console.WriteLine("Digite um numero inteiro: ");
// int number01 = int.Parse(Console.ReadLine());

// pode se usar Convert.ToInt16(Console.ReadLine())

// Console.WriteLine("Digite outro numero inteiro: ");
// int number02 = int.Parse(Console.ReadLine());

// int res = number01 == number02 ? number01 + number02 : number01 * number02;

// Console.WriteLine("Resultado: " + res);


// 02 pegue um numero e veja se é par ou ímpar

// Console.WriteLine("Digite um numero inteiro: ");
// int number01 = int.Parse(Console.ReadLine());

// string res = number01 % 2 == 0 ? "par" : "ímpar";
// Console.WriteLine(res);

// pega um dia do mes de setembro de 2024 e veja que dia da semana é

// Console.WriteLine("Informe um dia do mês de setembro de 2024");
// int dia = Convert.ToInt16(Console.ReadLine());

// string[,] sptemberMonth = {
//     {"01", "domingo"},
//     {"02", "segunda-feira"},
//     {"03", "terça-feira"},
//     {"04", "quarta-feira"},
//     {"05", "quinta-feira"},
//     {"06", "sexta-feira"},
//     {"07", "sábado"},
//     {"08", "domingo"},
//     {"09", "segunda-feira"},
//     {"10", "terça-feira"},
//     {"11", "quarta-feira"},
//     {"12", "quinta-feira"},
//     {"13", "sexta-feira"},
//     {"14", "sábado"},
//     {"15", "domingo"},
//     {"16", "segunda-feira"},
//     {"17", "terça-feira"},
//     {"18", "quarta-feira"},
//     {"19", "quinta-feira"},
//     {"20", "sexta-feira"},
//     {"21", "sábado"},
//     {"22", "domingo"},
//     {"23", "segunda-feira"},
//     {"24", "terça-feira"},
//     {"25", "quarta-feira"},
//     {"26", "quinta-feira"},
//     {"27", "sexta-feira"},
//     {"28", "sábado"},
//     {"29", "domingo"},
//     {"30", "segunda-feira"}
// };

// for(int i = 0; i < sptemberMonth.GetLength(0); i++)
// {
//   if(Convert.ToInt16(sptemberMonth[i, 0]) == dia){
//       Console.WriteLine("O dia escolhido foi " + sptemberMonth[i, 0] + ": " + sptemberMonth[i, 1]);
//   }
// }

// veja se um ano é bissexto

// Console.WriteLine("Diga um ano para verificar se é bissexto");

// int year = int.Parse(Console.ReadLine()); 

// Console.WriteLine(year % 4 == 0 ? "bissexto" : "não bissexto");