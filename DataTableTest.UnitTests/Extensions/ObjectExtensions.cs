namespace DataTableTest.UnitTests.Extensions;

public static class ObjectExtensions
{
    public static object GetReflectedProperty(this object obj, string propertyName)
    {  
        var property = obj.GetType().GetProperty(propertyName);

        if (property == null) return null;

        return property.GetValue(obj, null);
    }
}