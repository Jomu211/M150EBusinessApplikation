using M150EBusinessApplikation.Data;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;


namespace M150EBusinessApplikation.Services
{
    public class UserService
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private ApplicationDbContext Db;
        public UserService(ApplicationDbContext db, AuthenticationStateProvider authenticationStateProvider)
        {
            Db = db;
            _authenticationStateProvider = authenticationStateProvider;

        }
        public void LoadUserAsync(out ClaimsPrincipal? user, out string? name)
        {
            var authState = _authenticationStateProvider.GetAuthenticationStateAsync();
            user = authState.Result.User;
            name = user.Identity?.Name;
        }
        public UserProfil InitializeUserProfil(string name)
        {
            var userProfil = Db.UserProfiles.FirstOrDefault(u => u.Username == name);

            if (userProfil != null) return userProfil;
            {
                Db.UserProfiles.Add(new Data.UserProfil()
                {
                    Username = name,
                    Coins = 0,
                    Tries = null,
                    PresentReceived = false
                });
                Db.SaveChanges();
                return Db.UserProfiles.FirstOrDefault(u => u.Username == name);

            }
            
        }


    }
}
