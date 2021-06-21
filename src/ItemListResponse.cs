using System;
using System.Collections.Generic;

namespace Mh.Aladin
{
    public class ItemListItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime PubDate { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Isbn { get; set; }
        public string Isbn13 { get; set; }
        public int ItemId { get; set; }
        public int Mileage { get; set; }
        public string Cover { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Publisher { get; set; }
        public int PriceSales { get; set; }
        public int PriceStandard { get; set; }
        public string MallType { get; set; }
        public string StockStatus { get; set; }
        public int SalesPoint { get; set; }
        public bool Adult { get; set; }
        public bool FixedPrice { get; set; }
        public SeriesInfo SeriesInfo { get; set; }
    }

    public class ItemListResponse : ItemResponse
    {
        public IEnumerable<ItemListItem> Item { get; set; }
    }
}
