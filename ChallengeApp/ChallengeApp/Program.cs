
Employe employee1 = new Employe ("Fredek", "Nowak", "25");
Employe employee2 = new Employe ("Marek", "Komarek ","30");
Employe employee3 = new Employe ("Jozek",  "Bizon","35");
Employe employee4 = new Employe ("Czesiek", "Gniewek","40");
Employe employee5 = new Employe ("Monika", "Bzyk", "45");

employee1.Addscore(3);
employee1.Addscore(3);
employee1.Addscore(1);
employee1.Addscore(4);
employee1.Addscore(9);
employee1.Addscore(1);

employee2.Addscore(5);
employee2.Addscore(3);
employee2.Addscore(4);
employee2.Addscore(6);
employee2.Addscore(10);
employee2.Addscore(10);

employee3.Addscore(1);
employee3.Addscore(1);
employee3.Addscore(2);
employee3.Addscore(3);
employee3.Addscore(7);
employee3.Addscore(4);

employee4.Addscore(4);
employee4.Addscore(1);
employee4.Addscore(9);
employee4.Addscore(4);
employee4.Addscore(1);
employee4.Addscore(1);

employee5.Addscore(3);
employee5.Addscore(3);
employee5.Addscore(9);
employee5.Addscore(1);
employee5.Addscore(2);
employee5.Addscore(1);



List<Employe> employes = new List<Employe>()
{
    employee1,employee2,employee3,employee4,employee5

};


int maxResult = 0;
Employe EmployeewithMaxResult = null;

foreach(var employee in employes) 
{
    if (employee.Result > maxResult) 
    {
        maxResult = employee.Result; 
        EmployeewithMaxResult = employee;
    }
}


Console.WriteLine($"Najlepszy z najlepszych { EmployeewithMaxResult.Name} {EmployeewithMaxResult.Surname} { EmployeewithMaxResult.Age}latek   otrzymal  {maxResult} punktow ");

class Employe
{
    private List <int> score = new List<int>();
    public Employe(string name, string surname,string  age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; private set; }

    public string Surname { get; private set; }
    public string Age { get; private set; }
   
    public int  Result 
    {
        get 
        {
            return this.score.Sum();
        }
    
    }
    public void Addscore(int number) 
    {
        this.score.Add(number);
    }
   
}
