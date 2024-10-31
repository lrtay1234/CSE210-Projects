

public class House
{
    public string _owner;
    public Blind _kitchen;
    public Blind _livingRoom;
}



// this it the noram wordage, house name = new house... house is the class
House johnsonHome = new House();

johnsonHome._kitchen = new Blind();
johnsonHome._livingRoom = new Bind();


//or


public class House
{
    public string _owner = "";
    public Blind _kitchen = new Blind();
    public Blind _livingRoom = new Blind();
}



// call the class and new. Then declare the chosen variable and use the .attriubute and = to whatever it is.
House johnsonHome = new House();
johnsonHome._owner = "Johnson Family";

johnsonHome._kitchen.width = 60;
johnsonHome._livingRoom.length = 48;