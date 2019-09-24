using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AINIWorkshop3Sample.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Collections;

namespace AINIWorkshop3Sample.Controllers
{
    public class HomeController : Controller
    {
        //IMPORTANT: Set this
        private string apiKey = "API_KEY_HERE";

        //This acts as our list of supported animals. Kept as 2 string arrays for simplicity
        //The index of an animal and its corresponding enclosure should match. I.e. animalTypes[3]'s enclosure must be enclosureTypes[3]
        private string[] animalTypes = { "penguin", "giraffe", "monkey", "elephant" };
        private string[] enclosureTypes = { "arctic", "safari", "jungle", "safari" };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IFormCollection data)
        {
            //Retrieve the image URL entered into the textbox. Store it inside of ViewData so that it can be rendered on the page
            string imageURL = data["urlInput"];
            ViewData["originalImage"] = imageURL;

            //TODO: Create a HttpClient
            //TODO: Create the request to Azure containing the endpoint, headers, and body
            //TODO: Save the response from Azure as a Newtonsoft JSON Object
            //TODO: Send this response for processing to analyseData()
            //TODO: Save the result to ViewData["result"] so that it can be displayed on screen

            //Hint: You can use the "await" keyword when making the request and reading the response
            //      This ensures that any future code does not run until the network request has been fully completed
            //      var response = await httpClient.PostAsync(baseUri, content);
            //Hint: JObject.Parse(aStringVariable) will convert a JSON-formatted string into a Newtonsoft JSON object

            ViewData["result"] = "User-friendly message describing the results!";
            return View();
        }

        private string analyseData(JObject response)
        {
            //TODO: Put the list of tags into a string[] array
            //TODO: Check if the tag "animal" was found by Azure
            //TODO: Check if the list of tags contain an animal that we support
            //TODO: If animal found, find its enclosure type
            //TODO: Check if the AI is confident in its prediction. If not, don't put it inside of an enclosure
            //TODO: Create a (user-friendly) message for each scenario

            //Hint: JArray.Parse(aStringVariable).ToObject<string[]>(); will convert a JSON-formatted string into a regular string[] array. One tag per index
            //Hint: The confidence of the prediction can be found in response["description"]["captions"][0]["confidence"]

            return "A user friendly message describing the results!";
        }

    }
}
