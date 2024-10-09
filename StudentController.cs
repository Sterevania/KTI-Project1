using System;
using Microsoft.AspNetCore.Mvs;

namespace SampleSecureWeb.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Create()
    {
        return View();
    }
}

 