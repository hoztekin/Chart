using Chart.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace Chart.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly AppDb db;

		public HomeController(ILogger<HomeController> logger, AppDb db)
		{
			_logger = logger;
			this.db = db;
		}

		public IActionResult Index()
		{
            List<DataPoint> dataPoints = new List<DataPoint>();

			//dataPoints.Add(new DataPoint("Herbal Medicines", 41));
			//dataPoints.Add(new DataPoint("Aroma Therapy", 22));
			//dataPoints.Add(new DataPoint("Homeopathy", 9));
			//dataPoints.Add(new DataPoint("Acupuncture", 7));
			//dataPoints.Add(new DataPoint("Massage Therapy", 5));
			//dataPoints.Add(new DataPoint("Reflexology", 6));
			//dataPoints.Add(new DataPoint("Osteopathy", 5));
			//dataPoints.Add(new DataPoint("Chiropractic", 5));

			var result = db.Examples.ToList();

			foreach (var item in result) 
			{
				dataPoints.Add(new DataPoint(item.Quarter, item.Sales));
			}

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

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
	}
}
