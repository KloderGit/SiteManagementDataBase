using System;
using DataBase.EntityFramework;
using Domain.Interfaces.Repositories;
using System.Linq;
using Domain.Core.User;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Domain.Core.Education;

namespace ConsoleTest_DataBase
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                IDataManager dm = new EFDataManager(db);

                foreach (var i in new AddCatogories().Create())
                {
                    dm.Categories.Add(i);
                }

                foreach (var i in new AddCertifications().Create())
                {
                    dm.Certifications.Add(i);
                }

                foreach (var i in new AddEducationTypes().Create())
                {
                    dm.EducationTypes.Add(i);
                }

                foreach (var i in new AddPrograms(dm).Create())
                {
                    dm.EducationPrograms.Add(i);
                }

                dm.Save();

                //foreach (var item in dm.Certifications.GetAll())
                //{
                //    Console.WriteLine($"{item.Title}.{item.Guid}");
                //}
                //Console.WriteLine($"{u.Id}.{u.FirstName} - {u.Email}");
                Console.ReadKey();
            }
        }
    }
}