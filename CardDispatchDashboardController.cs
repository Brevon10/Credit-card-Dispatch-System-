using Microsoft.AspNetCore.Mvc;
using CardDispatch.Models;
using System;

namespace CardDispatch.Controllers
{
    public class CardDispatchDashboardController : Controller
    {
        public IActionResult CardDispatchDashboard()
        {
            var model = new CardDispatchModel
            {
                FromDate = DateTime.Parse("2024-08-02"),
                ToDate = DateTime.Parse("2024-08-02")
            };
            return View("~/Views/Dashboard/CardDispatchDashboard.cshtml", model);
        }
    }
}
