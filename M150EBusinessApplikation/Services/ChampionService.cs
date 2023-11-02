using System.Linq;
using System.Security.Claims;
using M150EBusinessApplikation.Data;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace M150EBusinessApplikation.Services
{
    public class ChampionService
    {
        private ApplicationDbContext Db;
        public ChampionService(ApplicationDbContext db)
        {
            Db = db;
        }
        public List<UserGameChampion> LoadChampionsToBuy()
        {
            return Db.UserGameChampions.Where(t => t.Bought == false).ToList();
        }
        public List<Champion> LoadChampions()
        {
            return Db.Champions.Include(t => t.Head).ToList();
        }
        public void InitializeUserGameChampions(string? name, List<Champion> champions)
        {
            if (!Db.UserGameChampions.Any(u => u.Username == name))
            {
                foreach (var champ in champions)
                {
                    var userChamp = Db.UserGameChampions.FirstOrDefault(t => t.ChampionId == champ.Id && t.Username == name);
                    if (userChamp != null) continue;

                    var bought = champ.Id is <= 16 and >= 1;

                    if (name != null) Db.UserGameChampions.Add(new UserGameChampion { ChampionId = champ.Id, Username = name, Hidden = false, Bought = bought });
                    Db.SaveChanges();
                }
            }

        }
        public async Task RestartGame(List<Champion> champions, IJSRuntime JsRuntime,string? name)
        {
            foreach (var champ in champions)
            {
                var userChamp = Db.UserGameChampions.FirstOrDefault(x => x.ChampionId == champ.Id && x.Username == name);
                if (userChamp != null)
                {
                    userChamp.Hidden = false;
                    userChamp.Chosen = false;
                    Db.Entry(userChamp).State = EntityState.Modified;
                }
            }
            await Db.SaveChangesAsync();
            await JsRuntime.InvokeVoidAsync("flipAll");
            await JsRuntime.InvokeVoidAsync("resultOutput", null);
        }


    }
}
