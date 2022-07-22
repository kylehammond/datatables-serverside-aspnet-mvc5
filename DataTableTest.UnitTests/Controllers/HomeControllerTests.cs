using System.Collections;
using System.Collections.Generic;
using DataTables.AspNet.Mvc5;
using DataTableTest.MVC.Controllers;
using DataTableTest.MVC.Models;
using DataTableTest.MVC.Services;
using DataTableTest.UnitTests.TestableObjects;
using NUnit.Framework;

namespace DataTableTest.UnitTests.Controllers;

[TestFixture]
public class HomeControllerTests
{
    [Test]
    public void GetTableData_WhenCalled_ReturnedCountShouldMatchNumberToTake()
    {
        var startIndex = 0;
        var numberToTake = 4;
        var homeController = CreateHomeController();
        var request = CreateBasicRequest(1, startIndex, numberToTake, string.Empty);

        var result = (DataTablesJsonResult)homeController.GetTableData(request, "some value");
        var data = (DataTablesResponse)result.Data;
        var dataValues = (IList)data.Data;

        Assert.That(dataValues.Count == numberToTake);
    }

    private static HomeController CreateHomeController()
    {
        var dataService = CreateDataTableDataService();
        return new HomeController(dataService);
    }

    private static DataTableDataService CreateDataTableDataService()
    {
        return new DataTableDataService
        {
            Items = new List<Item>
            {
                new() { Id = 1, FirstName = "Bob", LastName = "Bobbertson" },
                new() { Id = 2, FirstName = "Sam", LastName = "Sampleton" },
                new() { Id = 3, FirstName = "Jane", LastName = "Janesey" },
                new() { Id = 4, FirstName = "Dick", LastName = "Dickle" },
                new() { Id = 5, FirstName = "Bob", LastName = "Bobbertson" },
                new() { Id = 6, FirstName = "Sam", LastName = "Sampleton" },
                new() { Id = 7, FirstName = "Jane", LastName = "Janesey" },
                new() { Id = 8, FirstName = "Dick", LastName = "Dickle" },
                new() { Id = 9, FirstName = "Bob", LastName = "Bobbertson" },
                new() { Id = 10, FirstName = "Sam", LastName = "Sampleton" },
            }
        };
    }

    private static TestableDataTablesRequest CreateBasicRequest(int draw, int start, int length, string searchValue)
    {
        return new TestableDataTablesRequest
        {
            Draw = draw,
            Start = start,
            Length = length,
            Search = string.IsNullOrEmpty(searchValue) ? new Search() : new Search(searchValue)
        };
    }
}