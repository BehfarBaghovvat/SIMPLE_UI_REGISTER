namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{

		}

		#region Address
		public string Address { get; set; }
		#endregion Address

		#region FirstName
		public string First_Name { get; set; }
		#endregion /FirstName

		#region LastName
		public string Last_Name { get; set; }
		#endregion /LastName
	}
}

