using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using MyMongoDbApp.Models;
using MyMongoDbApp.Repositories;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MyMongoDbApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Transaction> _transactionRepository;
        public HomeController(ILogger<HomeController> logger, IRepository<Transaction> transactionRepository)
        {
            _logger = logger;
            _transactionRepository = transactionRepository;
        }

        public async Task<IActionResult> Index()
        {
            var t = new Transaction
            {
                Id = ObjectId.GenerateNewId(),
                PolicyNo = 307000000000124,
                RenewalNo = 0,
                EndorsNo = 0,
                ChannelNo = 0,
                Message = "Başarılı"
            };
            _transactionRepository.InsertOne(t);
            var t2 = new Transaction
            {
                Id = ObjectId.GenerateNewId(),
                PolicyNo = 307000000000125,
                RenewalNo = 0,
                EndorsNo = 0,
                ChannelNo = 0,
                Message = "Başarılı"
            };
            await _transactionRepository.InsertOneAsync(t2);

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