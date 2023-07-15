namespace Part01.Step_070
{
	public class Age : ValueObject
	{
		public static FluentResults.Result<Age> Create(int value)
		{
			var result = new FluentResults.Result<Age>();
			if (value <= 0 || value > 100)
			{
				//Resourc File
				string message = "Age value is null !";
				result.WithError(message);
				return result;
			}
			var resultAge = new Age(value);
			result.WithValue(resultAge);
			return result; 
		}
		private Age() : base()
		{
		}
		private Age(int value) : this()
		{
			Value = value;
		}
		public int Value { get; }
	}
}