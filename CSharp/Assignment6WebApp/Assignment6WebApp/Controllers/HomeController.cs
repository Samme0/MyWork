using System.Diagnostics;
using Assignment6WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Assignment6WebApp.ViewModels.Home;
using Assignment6WebApp.ViewFunctions.Home;

namespace Assignment6WebApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<string> listOfSentences = new List<string>();

        public IActionResult Privacy()
        {
            return View(new IndexViewModel());
        }
        public IActionResult Index()
        {
            // Initialize the IndexViewModel
            var model = new IndexViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult LoadContent()
        {
            // Load sentences from the OriginalContent.txt file
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "OriginalContent.txt");
            var sentences = HomeViewFunctions.LoadSentences(filePath);
            var model = new IndexViewModel { Sentences = string.Join("\n", sentences) };
            return View("Index", model);
           

        
        }

        [HttpPost]
        public IActionResult AscendingOutput()
        {
            // Sort sentences in ascending order
            var sortedSentences = HomeViewFunctions.SortSentencesAscending(listOfSentences);
            WriteToFile("AscendingOutput.txt", sortedSentences);

            // Prepare model for the view
            var model = new AscendingViewModel { SortedSentences = string.Join("\n", sortedSentences) };
            return View("Ascending", model);
        }

        [HttpPost]
        public IActionResult DescendingOutput()
        {
            // Sort sentences in descending order
            var sortedSentences = HomeViewFunctions.SortSentencesDescending(listOfSentences);
            WriteToFile("DescendingOutput.txt", sortedSentences);

            // Prepare model for the view
            var model = new DescendingViewModel { SortedSentences = string.Join("\n", sortedSentences) };
            return View("Descending", model);
        }

        private void WriteToFile(string fileName, List<string> sentences)
        {
            // Write the list of sentences to a specified file
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var sentence in sentences)
                {
                    writer.WriteLine(sentence);
                }
            }
        }
    }
}