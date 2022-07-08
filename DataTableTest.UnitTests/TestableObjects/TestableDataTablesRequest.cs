using System.Collections.Generic;
using DataTables.AspNet.Core;

namespace DataTableTest.UnitTests.TestableObjects;

public class TestableDataTablesRequest : IDataTablesRequest
{
    public int Draw { get; set; }
    public int Start { get; set; }
    public int Length { get; set; }
    public ISearch Search { get; set; }
    public IEnumerable<IColumn> Columns { get; }
    public IDictionary<string, object> AdditionalParameters { get; }
}