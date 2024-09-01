class Employee : Pessoa
{
  private string? _role;
  private double _salary;

  public Employee(string name, int age, string role, double salary)
  {
    Name = name;
    Age = age;
    _role = role;
    _salary = salary;
    PresentationEmployee();
    Presentation();
  }

   protected void PresentationEmployee()
  {
    Console.WriteLine($"Cargo: {_role}");
    Console.WriteLine($"Salário: {_salary}");
  }
}