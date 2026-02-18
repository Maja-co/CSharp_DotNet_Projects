namespace Interface;

public class MedInterface {
    
}

public class ByWeightSorter : IComparer<Person> {
    public int Compare(Person? x, Person? y) {
        if (x == null || y == null) return 0;
        return x.Weight.CompareTo(y.Weight);
    }
}

public class ByNameSorter : IComparer<Person> {
    public int Compare(Person? x, Person? y) {
        if (x == null || y == null) return 0;
        return x.Name.CompareTo(y.Name);
    }
}

public class ByAgeSorter : IComparer<Person> {
    public int Compare(Person? x, Person? y) {
        if (x == null || y == null) return 0;
        return x.Age.CompareTo(y.Age);
    }
}