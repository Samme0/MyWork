using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment7WebApp.ViewModels;
using Assignment7WebApp.ViewModels.Home;
using System;

namespace Assignment7WebApp.Controllers
{
    public class HomeController : Controller
    {
        // Index action
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        // Create integers
        [HttpPost]
        public IActionResult CreateIntegers()
        {
            var rand = new Random();
            DataRepository.intList.Clear();
            for (int i = 0; i < 20; i++)
            {
                DataRepository.intList.Add(rand.Next(0, 51));
            }
            var model = new IndexViewModel
            {
                ListOfNumbers = GenericListOfNumbers(DataRepository.intList)
            };
            return View("Index", model);
        }

        // Create doubles
        [HttpPost]
        public IActionResult CreateDoubles()
        {
            var rand = new Random();
            DataRepository.doubleList.Clear();
            for (int i = 0; i < 20; i++)
            {
                double val = rand.NextDouble() * 50;
                val = Math.Round(val, 2);
                DataRepository.doubleList.Add(val);
            }
            var model = new IndexViewModel
            {
                ListOfNumbers = GenericListOfNumbers(DataRepository.doubleList)
            };
            return View("Index", model);
        }

        // Search
        [HttpPost]
        public IActionResult Search(string listType, string searchKey)
        {
            var model = new IndexViewModel();

            if (listType == "int")
            {
                var result = GenericLinearSearch(DataRepository.intList, searchKey);
                model.SearchResults = result;
            }
            else if (listType == "double")
            {
                var result = GenericLinearSearch(DataRepository.doubleList, searchKey);
                model.SearchResults = result;
            }

            // update list display
            model.ListOfNumbers = listType == "int"
            ? GenericListOfNumbers(DataRepository.intList)
            : GenericListOfNumbers(DataRepository.doubleList);

            model.SearchKey = searchKey;

            return View("Index", model);
        }

        // Clear all
        [HttpPost]
        public IActionResult Clear()
        {
            DataRepository.intList.Clear();
            DataRepository.doubleList.Clear();
            return RedirectToAction("Index");
        }

        // --- GENERIC METHODS ---

        private string GenericListOfNumbers<T>(List<T> list)
        {
            return string.Join(" ", list);
        }

        private string GenericLinearSearch<T>(List<T> list, string searchKey)
        {
            var indices = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToString() == searchKey)
                {
                    indices.Add(i);
                }
            }
            return indices.Count > 0 ? string.Join(", ", indices) : "Not found.";
        }
    }
}