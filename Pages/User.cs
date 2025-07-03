namespace Users
{
    public class User
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public List<Object> RegisteredEvents { get; set; } = new List<Object>();
    }
}