using Domain.Core.Education;
using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleTest_DataBase
{
    public class AddCertifications
    {
        public IEnumerable<Certification> Create()
        {
            XDocument xdoc = XDocument.Load("Certifications.xml");
            var collection = from xe in xdoc.Element("root").Elements("Item")
                             select new Certification
                             {
                                 Guid = new Guid(xe.Element("ГУИД").Value),
                                 Title = xe.Element("Наименование").Value
                             };

            return collection;
        }
    }
}
