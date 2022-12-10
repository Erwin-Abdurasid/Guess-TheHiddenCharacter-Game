namespace GuessTheHiddenCharacter.Game.Models;

public class Character
{
    public string? Name { get; set; } // Just an identity
    public Sex Gender { get; set; } // Just a help for displaying character
    public int Id { get; set; } // Character's Count

    // Character's Attributes
    public EyeBrow EyeBrow { get; set; }
    public Eye Eyes { get; set; }
    public Color Color { get; set; }
    public Face Face { get; set; }
    public Nose Nose { get; set; }
    public Lip Lip { get; set; }
    public Height Height { get; set; }
    public Weight Weight { get; set; }

    public override string ToString()
    {
        string gender = Gender == Sex.Male ? "He" : "She";
        string genderVerb = Gender == Sex.Male ? "His" : "Her";

        // How to display a character
        return $"{gender} is {Name},\n" +
            $"{genderVerb.ToLower()} attributes are:\n" +
            $"{gender} has the eyes of {Eyes} with {EyeBrow} eyebrows,\n" +
            $"{genderVerb} color is {Color},\n" +
            $"{gender} is {Face},\n" +
            $"{genderVerb} nose is {Nose},\n" +
            $"{genderVerb} lips is {Lip},\n" +
            $"{gender} is {Height} (height) and {Weight} (weight).";
    }
}

public enum Sex
{
    Male, Female
}

public enum Color
{
    White, Normal, Black
}

public enum Face
{
    Handsome, Beautiful, Cute, Normal, Ugly
}

public enum EyeBrow
{
    Thick, Thin
}

public enum Eye
{
    Black, Brownish
}

public enum Nose
{
    Straight, Flat
}

public enum Lip
{
    Small, Big
}

public enum Height
{
    Tall, Middle, Small
}

public enum Weight
{
    Thin, Normal, Fit, Big, Large, Obessed
}
