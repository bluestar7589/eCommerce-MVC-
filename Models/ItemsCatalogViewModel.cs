namespace eCommerce_MVC_.Models
{
    public class ItemsCatalogViewModel
    {
        public List<Item> Items { get; set; } = null!;
        /// <summary>
        /// This is the current page
        /// </summary>
        public int CurrentPage { get; private set; }

        /// <summary>
        /// This is the last page of catalog calculate by the total number of items
        /// divided by the number of items per page
        /// </summary>
        public int LastPage { get; private set; }

        public ItemsCatalogViewModel(List<Item> lstItems, int lastPage, int currentPage)
        {
            Items = lstItems;
            CurrentPage = currentPage;
            LastPage = lastPage;
        }
    }
}
