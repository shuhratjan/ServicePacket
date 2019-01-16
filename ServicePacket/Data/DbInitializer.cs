using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ServicePacket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePacket.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                var c1 = new Category {
                    Name = "Услуги со сроком",
                    Code = 1,
                    ParentID = null,
                    Services=new List<Service>()
                    {
                        new Service{Name="Онлайн поиск актуальных тендеров",Price=5000},
                        new Service{Name="Онлайн поиск победной цены",Price=6000},
                        new Service{Name="Рассылка тендеров",Price=6500},
                        new Service{Name="Рассылка итогов тендеров",Price=7000}

                    }
                };
                var c2= new Category { Name = "Услуги без срока", Code = 2, ParentID = null };
                var c3 = new Category {
                    Name = "Участие в тендере без вознаграждения",
                    Code = 3,
                    ParentID = c2.CategoryID,
                    Services = new List<Service>()
                    {
                        new Service{Name="Подача ценового предложения",Price=7500},
                        new Service{Name="Подготовка документации: конкурс, аукцион или тендер(товары, услуги)",Price=8000},
                        new Service{Name="Подготовка документации: конкурс, аукцион или тендер(работы)",Price=8500}

                    }
                };
                var c4 = new Category {
                    Name = "Участие в тендере с вознаграждения",
                    Code = 4,
                    ParentID = c2.CategoryID };
                var c5 = new Category { Name = "Регистрация на порталах goszakup.gov.kz, tender.sk.kz, reestr.nedloc.kz", Code = 5, ParentID = c2.CategoryID };
                var c6 = new Category { Name = "Дополнительные", Code = 6, ParentID = null };

            }
        }
    }
}
