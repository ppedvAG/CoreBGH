using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CoreBGH.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul07
{
    public class SearchApiModel : PageModel
    {
        //[BindProperty]
        //public string searchtext { get; set; }
        public IEnumerable<Todos> TodoListe { get; set; }
       
        public async Task<IActionResult> OnGetAsync([FromServices] IHttpClientFactory _clientFactory, [FromQuery] string searchtext)
        {

            var request = new HttpRequestMessage(HttpMethod.Get,
            $"https://jsonplaceholder.typicode.com/todos/userd={searchtext}");
            request.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                TodoListe = await JsonSerializer.DeserializeAsync
                    <IEnumerable<Todos>>(responseStream);
            }
            else
            {
                TodoListe = Array.Empty<Todos>();
            }
            return Page();
        }
    }
}