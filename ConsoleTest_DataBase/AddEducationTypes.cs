using Domain.Core.Education;
using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleTest_DataBase
{
    public class AddEducationTypes
    {
        public IEnumerable<EducationType> Create()
        {
            XDocument xdoc = XDocument.Load("EducationType.xml");
            var collection = from xe in xdoc.Element("root").Elements("Item")
                             select new EducationType
                             {
                                 Guid = new Guid(xe.Element("ГУИД").Value),
                                 Title = xe.Element("Наименование").Value
                             };

            return collection;
        }
    }
}
