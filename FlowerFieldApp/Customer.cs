/*
 * fn@gso-koeln.de 2018
 */

namespace FlowerFieldApp
{
	/// <summary>
	/// Class for creating customer objects
	/// </summary>
	public class Customer
	{
		/// <summary>
		/// Creates a new customer object
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		public Customer(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		/// <summary>
		/// Customers first name
		/// </summary>
		public readonly string FirstName;

		/// <summary>
		/// Customers last name
		/// </summary>
		public readonly string LastName;

		/// <summary>
		/// Gets the string representation of this customer object
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}
