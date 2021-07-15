using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using R6MIX.Models;
using R6MIX.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace R6MIX.Controllers
{
    public class ESportAPIController : Controller
    {
        private static string Token = "W4sBPkh2FWLjMAZEcLi8dxkZJ2PjL8Je5U_xLzlXksqeI517zW8";
        private static string TokenAsQuery = "token=" + Token;
        private static string ApiBaseUrl = "https://api.pandascore.co/r6siege/";
        public async Task<IActionResult> Index()
        {
            List<League> leagues = new List<League>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiBaseUrl + "leagues?" + TokenAsQuery))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    leagues = JsonConvert.DeserializeObject<List<League>>(apiResponse,
                            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                }
            }
            return View(leagues);
        }

        public async Task<IActionResult> League(int? id) {
            if (id == null)
            {
                return NotFound();
            }

            List<League> leagues = new List<League>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiBaseUrl + "leagues?" + TokenAsQuery))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    leagues = JsonConvert.DeserializeObject<List<League>>(apiResponse,
                            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                }
            }
            return View(leagues.First(m => m.id == id));
        }

        public async Task<IActionResult> AllPlayers()
        {
            List<Player> players = new List<Player>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiBaseUrl + "players?" + TokenAsQuery))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    players = JsonConvert.DeserializeObject<List<Player>>(apiResponse);
                }
            }
            return View(players);
        }
    }
}
