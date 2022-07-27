using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaluNatanApp.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaluNatanApp
{
    public static class WlApiController
    {
      public static HttpClient Client = new HttpClient();

      public static async Task<CompaniesRoot> SearchByNIP(string NIPToSearch)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            string request = $"https://wl-api.mf.gov.pl/api/search/nip/{NIPToSearch}?date={year}-{month.ToString("00")}-{day}";

            HttpResponseMessage response = await Client.GetAsync(request);
         
            if(response.StatusCode != HttpStatusCode.OK)
                return null;

            response.EnsureSuccessStatusCode();
            string v = await response.Content.ReadAsStringAsync();
            CompaniesRoot result = await response.Content.ReadAsAsync<CompaniesRoot>();

            return result;
        }
    }
}
