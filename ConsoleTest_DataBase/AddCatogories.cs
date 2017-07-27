using Domain.Core.Education;
using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleTest_DataBase
{
    public class AddCatogories
    {

        public IEnumerable<Category> Create()
        {
            XDocument xdoc = XDocument.Load("Categories.xml");
            var collection = from xe in xdoc.Element("root").Elements("Item")
                                 select new Category
                                 {
                                     Guid = new Guid(xe.Element("ГУИД").Value),
                                     Title = xe.Element("Наименование").Value
                                 };

            return collection;
        }
    }
}
