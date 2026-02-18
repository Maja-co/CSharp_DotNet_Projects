namespace Interface;

public class MedDelegates {
    public static Comparison<Person> alderComparison = (x, y) => x.Age.CompareTo(y.Age);
    public static Comparison<Person> weightComparison = (x, y) => x.Weight.CompareTo(y.Weight);
    public static Comparison<Person> nameComparison = (x, y) => x.Name.CompareTo(y.Name);
}