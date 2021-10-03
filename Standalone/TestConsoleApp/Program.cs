using Steamworks;
using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var steamId = new CSteamID(123456798);

            // Initialize Steam API.
            if (!SteamAPI.Init())
                return;

            SteamUserStats.RequestCurrentStats();

            // Store personal information.
            var userId = SteamUser.GetSteamID();
            var userName = SteamFriends.GetPersonaName();

            Console.WriteLine($"userId = {userId}");
            Console.WriteLine($"userName = {userName}");
        }
    }
}
