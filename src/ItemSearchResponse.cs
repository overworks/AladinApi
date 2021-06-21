using System.Collections.Generic;

namespace Mh.Aladin
{
    public class ItemSearchItem
    {

    }

    public class ItemSearchResponse : ItemResponse
    {
        public IEnumerable<ItemSearchItem> Item { get; set; }
    }
}
