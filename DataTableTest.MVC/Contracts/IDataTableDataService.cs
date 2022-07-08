using System.Collections.Generic;
using DataTableTest.MVC.Models;

namespace DataTableTest.MVC.Contracts
{
    public interface IDataTableDataService
    {
        List<Item> Items{get; set;}
        IEnumerable<Item> GetTestData();
    }
}