using System;
using System.Collections.Generic;
using System.IO;

namespace ListOfPeople {
    public class Person {
        // --- Properties fra opgaven ---
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }

        public Person(string data) {
            var L = data.Split(';');
            Name = L[0];
            Age = int.Parse(L[1]);
            Weight = int.Parse(L[2]);
            Score = int.Parse(L[3]);
            Accepted = false;
        }

        public override string ToString() {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Score: {Score}, Accepted: {Accepted}";
        }

        // ReadCsvFile
        public static List<Person> ReadCSVFile(string filename) {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename)) {
                string line;
                while ((line = file.ReadLine()) != null) {
                    var p = new Person(line);
                    list.Add(p);
                }
            }

            return list;
        }
    }
}