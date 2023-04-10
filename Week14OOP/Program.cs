Console.WriteLine("Name your dog: ");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);

Dog neighbourDog = new Dog("Good Girl");

Console.WriteLine($"My dog's name is {myDog.Name}.");
Console.WriteLine($"My neighbour dog's name is {neighbourDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHappeness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

//Console.WriteLine($"Level of Happiness: {myDog.LevelOfHappeness}");

//myDog.Bark();
//Console.WriteLine($"Level of Happiness: {myDog.LevelOfHappeness}");



class Dog
{
    private string _name; //field; ei ole avalikult kättesaadav - private
    private int _levelOfHappiness;

    //constructor
    public Dog(string name) //name - let the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter
    public string Name //peab olema suure tähega ja ilma alakriipsuta
    {
        get { return _name; }
    }

    public int LevelOfHappeness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName) //koera nime vahetamine
    {
        _name = newName;
        Console.WriteLine($"The Dog has been renamed to {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}