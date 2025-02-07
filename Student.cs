namespace DIKUCanteen;

using System.Security.Cryptography.X509Certificates;

public class Student: Person {
    
    public bool HasCups = false;
    public Student(string Name, string Occupation, int Age): base(Name, Occupation, Age){
    
    }
    public void TakeCups(Canteen canteen) {
        if (HasCups == false) {
            canteen.Cups--;
            Console.WriteLine($"Cup has been taken. Cups avaliable: {canteen.Cups} cups");
            HasCups = true;
        } else {
            Console.WriteLine($"Not enough cups. Cups avaliable: {canteen.Cups} cups");
        }
    }

    public void ReturnCups(Canteen canteen) {
        
        if (HasCups == true) {
            canteen.Cups++;
            Console.WriteLine($"You returned your cup. Cups avaliable: {canteen.Cups} cups");
            HasCups = false;

        } else {
            Console.WriteLine($"You don't have a cup to return. Cups avaliable: {canteen.Cups} cups");
        }
}
}
