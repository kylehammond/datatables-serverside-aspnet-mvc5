using System.Collections.Generic;
using DataTableTest.MVC.Contracts;
using DataTableTest.MVC.Models;

namespace DataTableTest.MVC.Services
{
    public class DataTableDataService : IDataTableDataService
    {
        public List<Item> Items { get; set; }

        public IEnumerable<Item> GetTestData()
        {
            return Items ??
                   new List<Item>
                   {
                       new Item { Id = 1, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 2, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 3, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 4, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 5, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 6, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 7, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 8, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 9, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 10, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 11, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 12, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 13, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 14, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 15, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 16, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 17, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 18, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 19, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 20, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 21, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 22, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 23, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 24, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 25, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 26, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 27, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 28, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 29, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 30, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 31, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 32, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 33, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 34, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 35, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 36, FirstName = "Dick", LastName = "Dickle" },
                       new Item { Id = 37, FirstName = "Bob", LastName = "Bobbertson" },
                       new Item { Id = 38, FirstName = "Sam", LastName = "Sampleton" },
                       new Item { Id = 39, FirstName = "Jane", LastName = "Janesey" },
                       new Item { Id = 40, FirstName = "Dick", LastName = "Dickle" },
                   };
        }
    }
}