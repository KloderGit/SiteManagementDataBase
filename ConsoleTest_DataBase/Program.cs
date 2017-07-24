using System;
using DataBase.EntityFramework;
using Domain.Core.User;
using System.Collections.Generic;

namespace ConsoleTest_DataBase
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                User user1 = new User
                {
                    FirstName = "Илья",
                    LastName = "Иджян",
                    ParentMidleName = "Юрьевич",
                    Email = "kloder@mail.ru",
                    Guid = Guid.NewGuid(),
                    Profile = new UserProfile
                    {
                        Birthday = new DateTime(1978, 02, 02),
                        Excellent = false,
                        Gender = "M",
                        Phone = "903-145-34-12",
                        Skype = "kloder1",
                        WWW = "VK"
                    },
                    Location = new UserLocation
                    {
                        Post = "123456",
                        Country = "Russia",
                        City = "Moscow",
                        Address = "Olympic pros, bld 62"
                    },
                    Photo = new UserPhoto
                    {
                        Url = "/local/pic.jpg"
                    },
                    Cards = new List<UserCard> {
                          new UserCard {
                               Guid = Guid.NewGuid(), Number = "234as34", PassCode = "fEda3442dE"
                          },
                          new UserCard {
                              Guid = Guid.NewGuid(), Number = "EEED3232", PassCode = "fdEEE##"
                          }
                      }
                };



                //// добавляем их в бд
                db.Users.Add(user1);
                //db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                //var users = db.Users.ToList();
                //Console.WriteLine("Список объектов:");
                //foreach (User u in users)
                //{
                //    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                //}
            }
            Console.Read();
        }
    }
}