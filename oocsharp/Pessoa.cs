class Pessoa 
{
  // atributo
  // atributos string tem que ter um valor, para burlar isso usamos ? antes
  public string ?Name;
  public int Age;

  // Métodos de apresentação
  public void Presentation(){
    Console.WriteLine($"Olá, meu nome é {Name}");
  }

  public string AgeVerify() {
    return Age >= 18 ? "Maior de idade" : "Menor de idade";
  }
}

class Student 
{
  public int Media { get; set; }
  public string ?Name { get; set; }


}