﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDevil.Models;
using DevDevil.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevDevil.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
