namespace Part01.Models
{
	public class Age : ValueObject
	{
		//Design pater factory
		public static Age Create(int value)
		{
			if ((value <= 0) || (value >= 100))
			{
				throw new System.ArgumentOutOfRangeException(nameof(value));
			}
			var result =
				new Age(value);
			return result;
		}
		//private
		private Age() : base()
		{
		}
		//private
		private Age(int value) : this()
		{
			Value = value;
		}
		public int Value { get; }

		//public void Increment()
		//{
		//	var age = new Age(this.Value + 1);
		//}
	}
}
