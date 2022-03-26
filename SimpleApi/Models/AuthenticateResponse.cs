namespace SimpleApi.Models;

using SimpleApi.Entities;

public class AuthenticateResponse
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FullName { get; set; }
    public string Token { get; set; }

    public AuthenticateResponse(User user, string token)
    {
        Id = user.Id;
        Username = user.Username;
        FullName = user.Name;
        Token = token;
    }
}
