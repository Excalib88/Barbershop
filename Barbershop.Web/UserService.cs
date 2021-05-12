namespace Barbershop.Web
{
	public class UserService : IUserService
	{
		public ApplicationUser GetUserById(int id)
		{
			return new ApplicationUser
			{
				Id = 1,
				Name = "Vasya"
			};
		}
	}
}