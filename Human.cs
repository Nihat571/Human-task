using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3;

class Human
{
    public string name;
    public string surName;
    public byte age;

    public Human()
    {
        
    }
    public Human(string name,string surName,byte age)
    {
        this.name = name;
        this.surName = surName;
        this.age = age;
    }

    public void ShowFullData()
    {
        Console.WriteLine($"name:{name}\nsurname:{surName}\nage:{age}");
    }

}
class User(string name):Human
{
    string userName = name;
    string password;
}
