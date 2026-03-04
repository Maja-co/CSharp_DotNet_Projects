namespace test.Models;

public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> PhoneNumbers { get; set; }
    public string Address { get; set; }
    public string Zip { get; set; }
    public string City { get; set; }
    private DateTime birthday;


    public Person(string firstName, string lastName, string address, string zip, string city) {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Zip = zip;
        City = city;

        PhoneNumbers = new List<string>();
    }


    public DateTime Birthday {
        get { return birthday; }
        set {
            DateTime now = DateTime.Now;
            int tempAge = now.Year - value.Year;
            if (now.Month < value.Month || (now.Month == value.Month && now.Day < value.Day)) {
                tempAge--;
            }

            if (tempAge < 0 || tempAge > 120) {
                throw new Exception("Age not accepted");
            }
            else {
                birthday = value;
            }
        }
    }
    
    public int Age {
        get {
            if (birthday == DateTime.MinValue) {
                return 0;
            }

            DateTime now = DateTime.Now;
            int age = now.Year - birthday.Year;

            if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day)) {
                age--;
            }

            return age;
        }
    }


    public void AddPhone(string phone) {
        PhoneNumbers.Add(phone);
    }
}