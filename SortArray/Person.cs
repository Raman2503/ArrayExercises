using System.Collections.Generic;

namespace SortingSearchingAlgorithms
{
	 internal class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		List<Person> persons = new List<Person>()
		{
			new Person("Bob", 79),
			new Person("Paul", 26),
			new Person("Steve", 31),
			new Person("Cory", 54),
			new	Person("Sara", 36),
			new Person("Joe",70)
		}; 
	}
}
