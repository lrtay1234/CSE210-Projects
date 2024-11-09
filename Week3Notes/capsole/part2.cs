// Notes

// Sometimes it's difficult to decide what class members should be public or private. 
// A good rule of thumb is to restrict access to class members as much as possible.

// example
// go to employee file in sandbox


// or

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
    ...
}