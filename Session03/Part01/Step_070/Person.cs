﻿namespace Part01.Step_070
{
	public class Person : Entity
	{

		public static FluentResults.Result<Person> Create(Age age)
		{
			var result = new FluentResults.Result<Person>();
			if (age is null)
			{
				result.WithError("person is null");
			}
			if (result.IsFailed)
				return result;

			Person? person = new Person(age);
			result.WithValue(person);
			return result;
		}
		private Person()
		{
		}
		private Person(Age age)
		{
			Age = age;
		}
		public Age Age { get; private set; }
		public FluentResults.Result IncrementAge()
		{
			//هر کلاسی مسئول کار خودش هست
			//اولین اصلی که در شی گرایی وجود دارد
			//ما دیگه نیامدیم از
			//if then else 
			//استفاده کنم

            FluentResults.Result<Age>? age = Age.Create(Age.Value + 1);
			if (age.IsSuccess)
			{
				Age = age.Value;
			}
			return age.ToResult();
		}
	}
}
