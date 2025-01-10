using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var categories = new List<Categories>
            {
                new Categories
                {
                    Id = 1,
                    Name = "الملاعب",
                    Icon = "<i class=\"fa fa-futbol-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
                    Url = "Stadiums"
                },
                new Categories
                {
                    Id = 2,
                    Name = "مباريات كأس العالم",
                    Icon = "<i class=\"fa fa-clock-o text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
                    Url = "Matches",
                },
                new Categories
                {
                    Id = 3,
                    Name = "الفنادق",
                    Icon = "<i class=\"fa fa-bed text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
                    Url = "Hotel",
                },
                new Categories
                {
                    Id = 4,
                    Name = "المواصلات",
                    Icon = "<i class=\"fa fa-car text-success\" aria-hidden=\"true\" style=\"font-size: 100px;\"></i>",
                    Url = "Transportation",
                }
            };

            return View(categories);
        }

        public IActionResult Stadiums()
        {
            var stadiums = new List<Stadiums>
            {
                new Stadiums
                {
                    SID = 1,
                    Name = "استاد الملك عبدالله",
                    Img = "\\img\\Kingabdullah.jpg",
                    Capacity = 70000,
                    City = "جدة",
                    CDate = new DateTime(1999, 7, 7),
                    Facility = new List<string>{"مقاعد", "مرافق حديثة"},
                    Length = 105,
                    Width = 68,
                    Type = "ملعب"
                },
                new Stadiums
                {
                    SID = 2,
                    Name = "استاد الملك فهد",
                    Img = "\\img\\KingFahad.jpg",
                    Capacity = 68700,
                    City = "الرياض",
                    CDate = new DateTime(1987, 3, 1),
                    Facility = new List<string>{"مقاعد", "مرافق حديثة", "خدمات VIP"},
                    Length = 105,
                    Width = 68,
                    Type = "ملعب"
                },
                new Stadiums
                {
                    SID = 3,
                    Name = "استاد المربع الجديد",
                    Img = "\\img\\squer.jpg",
                    Capacity = 46000,
                    City = "الرياض",
                    CDate = new DateTime(2032, 10, 15),
                    Facility = new List<string>{"مقاعد", "مواقف سيارات", "خدمات VIP"},
                    Length = 105,
                    Width = 68,
                    Type = "ملعب داخلي"
                },
                new Stadiums
                {
                    SID = 4,
                    Name = "استاد روشن",
                    Img = "\\img\\stuudiums.jpg",
                    Capacity = 45000,
                    City = "الرياض",
                    CDate = new DateTime(2022, 5, 20),
                    Facility = new List<string>{"مقاعد", "خدمات VIP", "مرافق حديثة"},
                    Length = 105,
                    Width = 68,
                    Type = "ملعب"
                }
            };

            ViewBag.StadiumsList = stadiums;
            return View(stadiums);
        }

        public IActionResult Matches()
        {
            var stadiumsList = ViewBag.StadiumsList as List<Stadiums>;

            var matches = new List<Matches>
            {
                new Matches
                {
                    Id = 1,
                    Date = new DateTime(2034, 6, 10),
                    Group = "A",
                    Team1 = "السعودية",
                    Team2 = "البرازيل",
                    Time = "19:00",
                },
                new Matches
                {
                    Id = 2,
                    Date = new DateTime(2034, 6, 11),
                    Group = "B",
                    Team1 = "ألمانيا",
                    Team2 = "فرنسا",
                    Time = "21:00",
                },
                new Matches
                {
                    Id = 3,
                Date = new DateTime(2034, 6, 12),
                    Group = "C",
                    Team1 = "إسبانيا",
                    Team2 = "البرتغال",
                    Time = "18:00",
                },
                new Matches
                {
                    Id = 4,
                    Date = new DateTime(2034, 6, 13),
                    Group = "D",
                    Team1 = "الأرجنتين",
                    Team2 = "إيطاليا",
                    Time = "21:00",
                }
            };

            return View(matches);
        }

        public IActionResult Hotel(string[] locations)
        {
            var hotels = new List<Hotel>
            {
                new Hotel
                {
                    HotelId = 1,
                    Name = "Mercure Riyadh Al Anoud",
                    Location = "الرياض",
                    Rating = 8.5,
                    ReviewCount = 54,
                    Description = "فندق حديث في وسط الرياض",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/607556564.jpg?k=f1b086206800a02346cf26311aca4594e9a934c258a311f95f3f8f9f51678136&o=",
                    Facility = new List<string> { "مواقف سيارات", "مرافق حديثة", "مسبح" },
                    DistanceFromCentre = 4.0,
                    IsNew = true,
                },
                new Hotel
                {
                    HotelId = 2,
                    Name = "Hadab Al Sahafa",
                    Location = "الرياض",
                    Rating = 8.1,
                    ReviewCount = 5500,
                    Description = "فندق جميل في حي الصحافة بالقرب من وسط الرياض",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/477838847.jpg?k=af3d35f7712449827a43e7c32046fe145ef5d33a5ab99262749eabe2c50a63be&o=&hp=1",
                    Facility = new List<string> { "مواقف سيارات", "مسبح", "غرف حديثة" },
                    DistanceFromCentre = 2.2,
                    IsNew = false,
                },
                new Hotel
                {
                    HotelId = 3,
                    Name = "Andalus Habitat Hotel",
                    Location = "جدة",
                    Rating = 8.0,
                    ReviewCount = 2280,
                    Description = "فندق جميل في جدة بالقرب من البحر الأحمر",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/265811950.jpg?k=caaa55d3b1460d02baa7357793d64fa6a8edfcfe458fd1bf6c73de6dcdcc1586&o=",
                    Facility = new List<string> { "مواقف سيارات", "مسبح", "مطعم فاخر" },
                    DistanceFromCentre = 1.1,
                    IsNew = false,
                }
            };

            if (locations != null && locations.Length > 0)
            {
                hotels = hotels.Where(h => locations.Contains(h.Location)).ToList();
            }

            return View(hotels);
        }

        public IActionResult Transportation()
        {
            var categories = new List<TransportationCategories>
            {
                new TransportationCategories { Id = 1, Name = "حافلة" },
                new TransportationCategories { Id = 2, Name = "سيارة" },
                new TransportationCategories { Id = 3, Name = "قطار" }
            };

            var transports = new List<Transportation>
            {
                new Transportation
                {
                    Id = "1",
                    Name = "الحافلات",
                    Capacity = 50,
                    vehicle = categories[0],
                    Img = " \\img\\bus.jpg " ,
                    Version = "2024",
                    color = "أحمر"
                },
                new Transportation
                {
                    Id = "2",
                    Name = "التاكسي",
                    Capacity = 4,
                    vehicle = categories[1],
                    Img = "\\img\\taxi.jpg",
                    Version = "2023",
                    color = "أصفر"
                },
                new Transportation
                {
                    Id = "3",
                    Name = "القطار",
                    Capacity = 200,
                    vehicle = categories[2],
                    Img = " \\img\\mitro.jpg " ,
                    Version = "2022",
                    color = "أزرق"
                }
            };

            return View(transports);
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
