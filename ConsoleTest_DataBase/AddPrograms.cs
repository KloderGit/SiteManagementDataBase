using Domain.Core.Education;
using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using Domain.Interfaces.Repositories;

namespace ConsoleTest_DataBase
{
    public class AddPrograms
    {
        IDataManager dman;

        public AddPrograms(IDataManager dm)
        {
            dman = dm;
        }

        public IEnumerable<EducationProgram> Create()
        {
            XDocument xdoc = XDocument.Load("Programs.xml");

            var collection = from xe in xdoc.Element("root").Elements("Item")
                             select new EducationProgram
                             {
                                 Guid = new Guid(xe.Element("ПрограммаОбучения").Element("ГУИД").Value),
                                 AcceptDate = Convert.ToDateTime( xe.Element("ПрограммаОбучения").Element("ДатаУтверждения").Value ),
                                 Title = xe.Element("ПрограммаОбучения").Element("Наименование").Value,
                                 Active = isBool(xe.Element("ПрограммаОбучения").Element("Статус").Value),
                                 ProgramType = xe.Element("ТипМероприятия").Element("Наименование").Value,
                                 StudyType = "Не указано",
                                 Category = Categ(xe.Element("ГруппаПрограммыОбучения").Element("ГУИД").Value),
                                 EducationType = dman.EducationTypes.GetLocal().FirstOrDefault( t=> t.Guid == new Guid (xe.Element("ФормаОбучения").Element("ГУИД").Value))
                             };

            return collection;
        }

        private bool isBool(string t) {
            if (t == "Активный") { return true; }
            return false;
        }

        private Category Categ(string g) {
            var result = dman.Categories.GetLocal().FirstOrDefault(c => c.Guid == new Guid(g));
            return result;
        }
    }
}
