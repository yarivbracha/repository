using System;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace XLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var allTypes = from type in typeof(string).Assembly.GetExportedTypes()
                           where type.IsClass
                           let properties = type.GetProperties()
                           select new XElement("Type", new XAttribute("FullName", type.FullName), new XElement("Properties",
                                   from property in properties
                                   select new XElement("Property",
                                       new XAttribute("Name", property.Name),
                                       new XAttribute("Type", property.PropertyType.FullName ?? "T"))),
                               new XElement("Methods", from method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                                                       where !method.IsSpecialName
                                                       select new XElement("Method", new XAttribute("Name", method.Name), new XAttribute("ReturnType", method.ReturnType.FullName ?? "Type"),
                                                        new XElement("Parameters",
                                                            from parameter in method.GetParameters()
                                                            select new XElement("Parameter", new XAttribute("Name", parameter.Name), new XAttribute("Type", parameter.ParameterType))))));
            var xml = new XElement("Types", allTypes);

            /////////////////////////3 a////////////////////////////////////////
            var withoutProperties = from type in allTypes
                                    where type.Element("Properties").Descendants().Count() == 0
                                    let typeName = (string)type.Attribute("FullName")
                                    orderby typeName
                                    select typeName;
            foreach (var type in withoutProperties)
            {
                Console.WriteLine(type);
            }
            Console.WriteLine($"All types without properties: {withoutProperties.Count()}");

            /////////////////////////3 b////////////////////////////////////////
            int methodsSum = allTypes.Sum(type => type.Descendants("Method").Count());
            Console.WriteLine($"All methods without Inherited: {methodsSum}");

            /////////////////////////3 c////////////////////////////////////////
            int pros = allTypes.Sum(type => type.Descendants("Properties").Count());
            Console.WriteLine($"All properties: {pros}");

            var parameters = from param in allTypes.Descendants("Parameter")
                             group param
                             by (string)param.Attribute("Type")
                                      into groupParam
                             orderby groupParam.Count() descending
                             select new
                             {
                                 name = groupParam.Key,
                                 count = groupParam.Count()
                             };

            foreach (var param in parameters)
            {
                Console.WriteLine($"The most common parameter is {param}");
                break;
            }

            /////////////////////////3 d////////////////////////////////////////
            var propertiesMethods = from type in allTypes
                                    let methods = type.Descendants("Method").Count()
                                    orderby methods descending
                                    select new
                                    {
                                        methods = methods,
                                        properties = type.Descendants("Property").Count(),
                                        name = (string)type.Attribute("FullName")
                                    };

            XElement propertiesMethodsXml = new XElement("Types",
                                  from element in propertiesMethods
                                  select new XElement("Type",
                                      new XAttribute("Name", element.name),
                                      new XAttribute("Methods", element.methods),
                                      new XAttribute("Properties", element.properties)));
            Console.WriteLine(propertiesMethodsXml);

            /////////////////////////3 e////////////////////////////////////////
            var types = from type in allTypes
                        orderby (string)type.Attribute("FullName")
                        group new
                        {
                            Methods = type.Descendants("Method").Count(),
                            Properties = type.Descendants("Property").Count(),
                            Name = (string)type.Attribute("FullName")
                        }
                        by type.Descendants("Method").Count()
                                            into groupByMethods
                        orderby groupByMethods.Key descending
                        select groupByMethods;

            foreach (var group in types)
            {
                foreach (var type in group)
                {
                    Console.WriteLine($"Name -  {type.Name}\nProperties sum -{type.Properties}\nMethods sum - {type.Methods}");
                }
            }
        }

    }
}

