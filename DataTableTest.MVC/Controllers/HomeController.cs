using System.Linq;
using System.Web.Mvc;
using DataTables.AspNet.Core;
using DataTables.AspNet.Mvc5;
using DataTableTest.MVC.Contracts;
using DataTableTest.MVC.Services;

namespace DataTableTest.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataTableDataService _dataService;

        public HomeController(IDataTableDataService dataService)
        {
            _dataService = dataService;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTableData(IDataTablesRequest request)
        {
            var allData = _dataService.GetTestData().Where(d=>d.FirstName.ToLower().Contains(request.Search.Value.ToLower())).ToList();
            var filteredData = allData.Skip(request.Start).Take(request.Length).ToList();
            
            var response = DataTablesResponse.Create(request, allData.Count, allData.Count, filteredData);
            return new DataTablesJsonResult(response, JsonRequestBehavior.AllowGet);
        }
    }
}