/*
 * fn@gso-koeln.de 2018
 */

namespace FlowerFieldApp
{
	public class Customer
	{
		public Customer(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public readonly string FirstName;

		public readonly string LastName;

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}
