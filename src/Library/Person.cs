public abstract class Person
{
    public string Name{get;}
    public string Surname{get;}
    public int Id{get;}
    public int Qualification{get;}

    public string ProfilePhotoPath{get;}

    public Person(string name, string surname, int id, int qualification, string profilePhotoPath)
    {
        this.Name = name;
        this.Surname = surname;
        this.Id = id;
        this.Qualification = qualification;
        this.ProfilePhotoPath = profilePhotoPath;
    }

}