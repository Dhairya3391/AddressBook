namespace AdressBook.Models;

public class UserModel
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string MobileNumber { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string confirmPassword { get; set; }
}