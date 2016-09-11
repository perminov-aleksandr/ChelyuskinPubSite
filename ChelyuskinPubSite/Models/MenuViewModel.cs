using System.Collections.Generic;
using System.ComponentModel;

namespace ChelyuskinPubSite.Models
{
    [DisplayName("Меню")]
    public class MenuViewModel
    {
        public List<MenuSection> Sections { get; set; }
    }

    [DisplayName("Раздел меню")]
    public class MenuSection
    {
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }
    }

    [DisplayName("Элемент меню")]
    public class MenuItem
    {
        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Объем")]
        public int Amount { get; set; }

        [DisplayName("Единицы измерения")]
        public AmountType AmountType { get; set; }

        [DisplayName("Цена")]
        public int Price { get; set; }

        [DisplayName("Валюта")]
        public Currency Currency { get; set; }

        [DisplayName("Состав")]
        public Consist Consist { get; set; }

        [DisplayName("Метки")]
        public List<string> Tags { get; set; }
    }

    public enum Currency
    {
        Rub, Eur, Usd
    }

    [DisplayName("Состав")]
    public class Consist
    {
        [DisplayName("Ингридиенты")]
        public List<string> Elements { get; set; } 
    }

    [DisplayName("Единица измерения")]
    public class AmountType
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}