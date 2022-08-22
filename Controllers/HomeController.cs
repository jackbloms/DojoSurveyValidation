using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpPost("/success")]
    public IActionResult Submission(Survey yourSurvey)
    {
        if(ModelState.IsValid)
        {
            return View("Success", yourSurvey);
        }
        else
        {
            return Index();
        }
    }
}

