namespace DIKUCanteen;
using System;

class Program {

    static void Main(string[] args) {
        Canteen myCanteen = new Canteen("Canteen");
        Student myStudent = new Student("Magnus", "Student", 23);
        CanteenBoardMember myCanteenBoardMember = new CanteenBoardMember("Kasper", "Board Member", 24);
        myStudent.TakeCups(myCanteen);
        myCanteenBoardMember.TakeCups(myCanteen);
        myStudent.ReturnCups(myCanteen);
        myCanteenBoardMember.ReturnCups(myCanteen);
        myCanteenBoardMember.BuyCup(myCanteen);
        myCanteenBoardMember.BuyCup(myCanteen);
        myCanteenBoardMember.BuyCup(myCanteen);
        myCanteen.Cups = 2;
        myCanteenBoardMember.TakeCups(myCanteen);
        myCanteenBoardMember.TakeCups(myCanteen);
        myCanteenBoardMember.TakeCups(myCanteen);
        myCanteenBoardMember.TakeCups(myCanteen);
        myCanteenBoardMember.ReturnCups(myCanteen);
        myCanteenBoardMember.ReturnCups(myCanteen);
        myCanteenBoardMember.ReturnCups(myCanteen);
        myCanteenBoardMember.ReturnCups(myCanteen);
    }
}

