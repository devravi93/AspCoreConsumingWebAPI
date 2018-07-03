using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreConsumingWebApi.Factory;
using AspCoreConsumingWebApi.Models;
using AspCoreConsumingWebApi.Utility;
using AspCoreModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AspCoreConsumingWebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MySettingsModel> appSettings;

        public HomeController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
        }

        public async Task<IActionResult> Index()
        {
            var data = await ApiClientFactory.Instance.GetUsers();
            var response = await SaveUser();
            return View();
        }

        private async Task<JsonResult> SaveUser()
        {
            var model = new UsersModel()
            {
                Id = 0,
                Name = "Lionel Messi",
                EmailId = "iam@messi.com",
                Mobile = "4234235423",
                Address = "Barcelona",
                IsActive = true
            };
            var response = await ApiClientFactory.Instance.SaveUser(model);
            return Json(response);
        }
    }
}