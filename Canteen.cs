namespace DIKUCanteen;

public class Canteen : Room {

    int cups = 100;
    public int Cups {
        get {
            return cups;
        }
        set { 
            cups = value;
        }
    }
    public Canteen(string name) : base(name) {
    }
    public Canteen(string name, int cups) : base(name) {
        this.cups = cups;
    }
    public override string ToString() {
        return $"name: {name}, Cups: {cups}";
    }
}

