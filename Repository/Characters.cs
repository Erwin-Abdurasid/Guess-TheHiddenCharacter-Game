namespace GuessTheHiddenCharacter.Game.Repository;

public class Characters
{
    public IEnumerable<Character> GetCharacters
        => new List<Character>
        {
            // 1
            new Character { Name = "Kevin", Gender = Sex.Male, Id = 1,
                EyeBrow = EyeBrow.Thin, Eyes = Eye.Brownish, Color = Color.White,
                Face = Face.Handsome, Nose = Nose.Straight, Lip = Lip.Small,
                Height = Height.Tall, Weight = Weight.Fit },
            // 2
            new Character { Name = "Jiham", Gender = Sex.Male, Id = 2,
                EyeBrow = EyeBrow.Thick, Eyes = Eye.Black, Color = Color.Normal,
                Face = Face.Cute, Nose = Nose.Straight, Lip = Lip.Small,
                Height = Height.Middle, Weight = Weight.Normal },
            // 3
            new Character { Name = "Melissa", Gender = Sex.Female, Id = 3,
                EyeBrow = EyeBrow.Thin, Eyes = Eye.Black, Color = Color.White,
                Face = Face.Beautiful, Nose = Nose.Straight, Lip = Lip.Small,
                Height = Height.Middle, Weight = Weight.Fit },
            // 4
            new Character { Name = "Mara", Gender = Sex.Female, Id = 4,
                EyeBrow = EyeBrow.Thick, Eyes = Eye.Black, Color = Color.Normal,
                Face = Face.Ugly, Nose = Nose.Flat, Lip = Lip.Big,
                Height = Height.Middle, Weight = Weight.Big },
            // 5
            new Character { Name = "Gaba", Gender = Sex.Male, Id = 5,
                EyeBrow = EyeBrow.Thick, Eyes = Eye.Brownish, Color = Color.Black,
                Face = Face.Normal, Nose = Nose.Flat, Lip = Lip.Big,
                Height = Height.Tall, Weight = Weight.Large },
            // 6
            new Character { Name = "Jericho", Gender = Sex.Male, Id = 6,
                EyeBrow = EyeBrow.Thick, Eyes = Eye.Black, Color = Color.White,
                Face = Face.Handsome, Nose = Nose.Straight, Lip = Lip.Small,
                Height = Height.Middle, Weight = Weight.Fit },
            // 7
            new Character { Name = "Joana", Gender = Sex.Female, Id = 7,
                EyeBrow = EyeBrow.Thin, Eyes = Eye.Brownish, Color = Color.White,
                Face = Face.Cute, Nose = Nose.Straight, Lip = Lip.Big,
                Height = Height.Small, Weight = Weight.Normal },
            // 8
            new Character { Name = "Miya", Gender = Sex.Female, Id = 8,
                EyeBrow = EyeBrow.Thin, Eyes = Eye.Black, Color = Color.White,
                Face = Face.Cute, Nose = Nose.Straight, Lip = Lip.Small,
                Height = Height.Tall, Weight = Weight.Obessed },
            // 9
            new Character { Name = "Jobet", Gender = Sex.Male, Id = 9,
                EyeBrow = EyeBrow.Thick, Eyes = Eye.Brownish, Color = Color.Black,
                Face = Face.Ugly, Nose = Nose.Flat, Lip = Lip.Small,
                Height = Height.Middle, Weight = Weight.Big },
            // 10
            new Character { Name = "Cynthia", Gender = Sex.Female, Id = 10,
                EyeBrow = EyeBrow.Thin, Eyes = Eye.Black, Color = Color.White,
                Face = Face.Cute, Nose = Nose.Flat, Lip = Lip.Small,
                Height = Height.Small, Weight = Weight.Big }
        };
}
