using System.Collections;

namespace aaa
{
    class Program
    {
        public class Person 
        {
            public Person(string fName, string lName)
            {
                this.firstName = fName;
                this.lastName = lName;
            }

            public string firstName;
            public string lastName;
        }

        public class People : IEnumerable
        {
            private Person[] _people;

            public People(Person[] pArray)
            {
                _people = new Person[pArray.Length];

                for(int i = 0; i < pArray.Length; i++)
                {
                    _people[i] = pArray[i];
                }
            }

            public IEnumerator GetEnumerator()
            {
                return new PeopleEnum(_people);
            }
        }

        public class PeopleEnum : IEnumerator
        {
            public Person[] _people;

            int position = -1;

            public PeopleEnum(Person[] list)
            {
                _people = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _people.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            public object Current
            {
                get
                {
                    try
                    {
                        return _people[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("A", "a"),
                new Person("B", "b"),
                new Person("C", "c"),
            };

            People peopleList = new People(peopleArray);
            foreach(Person person in peopleList)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
        }
    }
}