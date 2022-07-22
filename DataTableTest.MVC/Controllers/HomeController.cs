using System;
using System.Linq;
using System.Web.Mvc;
using DataTables.AspNet.Core;
using DataTables.AspNet.Mvc5;
using DataTableTest.MVC.Contracts;
using DataTableTest.MVC.Models;

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

        [HttpPost]
        public ActionResult GetTableData(IDataTablesRequest request, string extraParameter)
        {
            var allData = _dataService.GetTestData();

            var sortColumn = request.Columns.FirstOrDefault(c => c.Sort != null);
            var sortField = sortColumn.Field[0].ToString().ToUpper() + sortColumn.Field.Substring(1);
            
            var orderedData = sortColumn.Sort.Direction == SortDirection.Ascending ? 
                allData.OrderBy(d => d.GetType().GetProperty(sortField)?.GetValue(d)) : 
                allData.OrderByDescending(d => d.GetType().GetProperty(sortField)?.GetValue(d));

            var filteredData = orderedData
                .Where(d => d.FirstName.ToLower().Contains(request.Search.Value.ToLower()))
                .Skip(request.Start)
                .Take(request.Length)
                .ToList();

            var response = DataTablesResponse.Create(request, allData.Count(), allData.Count(), filteredData);
            return new DataTablesJsonResult(response, JsonRequestBehavior.AllowGet);
        }
    }
}