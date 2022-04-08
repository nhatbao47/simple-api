namespace SimpleApi.Models;

using SimpleApi.Entities;

public class AuthenticateResponse
{
    public User LoginUser { get; set; }
    public string Token { get; set; }

    public AuthenticateResponse(User user, string token)
    {
        LoginUser = user; 
        Token = token;
    }
}
