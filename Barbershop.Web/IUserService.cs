namespace Barbershop.Web
{
	public interface IUserService
	{
		ApplicationUser GetUserById(int id);
	}
}