namespace DIKUCanteen;

using System.Security.Cryptography.X509Certificates;

public class CanteenBoardMember: Student {

    public static int CupBudget = 2;
    public CanteenBoardMember(string Name, string Occupation, int Age): base(Name, Occupation, Age){
        
    }

    public void BuyCup(Canteen canteen){
        CupBudget--;
        canteen.Cups++;
        if (CupBudget>=0) {
            Console.WriteLine($"You bought a cup. Current Budget: {CupBudget} cups, Current cup amount: {canteen.Cups} cups");
            

        } else {
            Console.WriteLine($"Not enough money to buy cups. You go in debt. Current Budget: {CupBudget} cups, Current cup amount: {canteen.Cups} cups");
        }

    }
}
