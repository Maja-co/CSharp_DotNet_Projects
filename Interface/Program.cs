using Interface;

List<Person> liste = new List<Person>();

liste.Add(new Person("Emil", 26, 90));
liste.Add(new Person("Emilie", 22, 65));
liste.Add(new Person("Julie", 23, 76));
liste.Add(new Person("Karl", 30, 106));
liste.Add(new Person("Ludvig", 25, 98));
liste.Add(new Person("Martin", 23, 70));
liste.Add(new Person("Maria", 26, 57));
liste.Add(new Person("Helle", 35, 90));
liste.Add(new Person("Lisa", 21, 87));
liste.Add(new Person("Tobias", 29, 130));
liste.Add(new Person("Bo", 25, 90));

// Kald til Interface-filen
liste.Sort(new ByAgeSorter());

// Kald til Delegates-filen
liste.Sort(MedDelegates.weightComparison);

// Kald til Lambda-filen
MedLambda.UdfoerLambdaSortering(liste);

public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }

    public Person(string name, int age, int weight) {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override string ToString() {
        return $"Name: {Name}, Age: {Age} year, Weight: {Weight} kg";
    }
}