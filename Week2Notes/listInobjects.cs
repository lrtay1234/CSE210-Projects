// 

public class House
{
    public string _owner;

    //List<int> numbers = new List<int>();
    //List<string> words = new List<string>();
    // this is what was used before
    public List<Blind> _blinds = new List<Blind>();
}

johnsonHome._blinds.Add(kitchen);


double amount = johnsonHome._blinds[0].GetArea();


foreach (Blind b in johnsonHome._blinds)
{
    double amount = b.GetArea();
}