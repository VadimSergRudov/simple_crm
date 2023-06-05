using Domain.Entities;
using System.Text.Json.Serialization;

namespace Application.Common.Models.Users
{
    public class AuthenticateResponse
    {
        public string Id { get; set; } // string or guid format think about it
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }

        [JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }

        public AuthenticateResponse(User user, string jwtToken, string refreshToken)
        {
            Id = user.Id.ToString();
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Login;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
        }
    }
}
