namespace NSE.Identity.API.Models
{
    public class UserRegister
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}