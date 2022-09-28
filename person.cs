// This will refer to the file "Program"
class Person
{
    // These are properties of the object
    string firstName;

    string lastName;

    string hairColor;

    // This is a constructor, the function that is called when you make the object
    public Person(string f, string l, string h)
    {
        firstName = f;
        lastName = l;
        hairColor = h;
    }

    public void greeting() 
    {
        Console.WriteLine($"Hello, my name is {firstName} {lastName}, my hair color is {hairColor}");
    }
}