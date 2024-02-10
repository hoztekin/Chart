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
            
			return View();
        }

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Dougnut()
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

		public IActionResult BarChart()
		{
			List<DataPoint> dataPointsbar = new List<DataPoint>();

			dataPointsbar.Add(new DataPoint("Albert", 10));
			dataPointsbar.Add(new DataPoint("Tim", 30));
			dataPointsbar.Add(new DataPoint("Wilson", 17));
			dataPointsbar.Add(new DataPoint("Joseph", 39));
			dataPointsbar.Add(new DataPoint("Robert", 30));
			dataPointsbar.Add(new DataPoint("Sophia", 25));
			dataPointsbar.Add(new DataPoint("Emma", 15));

			ViewBag.DataPointsBar = JsonConvert.SerializeObject(dataPointsbar);
			return View();
		}

		public IActionResult FunnelChart() 
		{
			List<DataPoint> dataPoints = new List<DataPoint>();

			dataPoints.Add(new DataPoint("Total", 100));
			dataPoints.Add(new DataPoint("Verified", 80));
			dataPoints.Add(new DataPoint("Processed", 75));
			dataPoints.Add(new DataPoint("Shipped", 70));
			dataPoints.Add(new DataPoint("Delivered", 68));

			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
