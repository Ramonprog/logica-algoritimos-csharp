class Pessoa 
{
  protected string? Name;
  protected int Age;

  protected void Presentation()
  {
    Console.WriteLine($"Nome: {Name}");
    Console.WriteLine($"Idade: {Age}");
  }
}