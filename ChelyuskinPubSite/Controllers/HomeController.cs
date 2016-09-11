using System.Collections.Generic;
using System.Web.Mvc;
using ChelyuskinPubSite.Models;

namespace ChelyuskinPubSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Menu()
        {
            var menu = new MenuViewModel
            {
                Sections = new List<MenuSection>
                {
                    new MenuSection
                    {
                        Name = "Завтраки",
                        Items = new List<MenuItem>
                        {
                            new MenuItem
                            {
                                Name = "Омлет с помидорами",
                                Price = 120,
                                Currency = Currency.Rub
                            },
                            new MenuItem
                            {
                                Name = "Овсяная каша",
                                Price = 95,
                                Currency = Currency.Rub
                            },
                            new MenuItem
                            {
                                Name = "Сэндвич с помидрами авокадо и моцареллой",
                                Price = 220,
                                Currency = Currency.Rub
                            }
                        }
                    },
                    new MenuSection
                    {
                        Name = "Закуски",
                        Items = new List<MenuItem>
                        {
                            new MenuItem
                            {
                                Name = "Копченый сыр сулугуни",
                                Price = 210,
                                Currency = Currency.Rub
                            },
                            new MenuItem
                            {
                                Name = "Мясное ассорти",
                                Price = 320,
                                Currency = Currency.Rub
                            },
                            new MenuItem
                            {
                                Name = "Вяленая оленина",
                                Price = 350,
                                Currency = Currency.Rub
                            }
                        }
                    },
                    new MenuSection
                    {
                        Name = "Горячее",
                        Items = new List<MenuItem>
                        {
                            new MenuItem
                            {
                                Name = "Свиные ребра BBQ",
                                Price = 430,
                                Currency = Currency.Rub
                            },
                            new MenuItem
                            {
                                Name = "Куриное филе в марокканских специях с кускусом",
                                Price = 360,
                                Currency = Currency.Rub
                            },
                            new MenuItem
                            {
                                Name = "Паста с томатами и сыром",
                                Price = 340,
                                Currency = Currency.Rub
                            }
                        }
                    }
                }
            };
            return View(menu);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}