using Part01.Models;

namespace Part01.Step_060
{
	public class Person : Entity
	{
		public static Person Create(int age)
		{
			Age ageValueObject = Age.Create(value: age);
			Person person = new Person(age: ageValueObject);
			return person;
		}
		private Person() : base()
		{
		}
		private Person(Age age) : this()
		{
			Age = age;
		}
		public Age Age { get; private set; }

		public void IncrementAgeByOne()
		{
			var age = Age.Create(Age.Value + 1);
		}
	}
}
