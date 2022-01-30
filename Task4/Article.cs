namespace Task4
{
    internal class Article
    {
        private string? _titleOfArticle;
        private string? _titleOfStore;
        private int _price; //в руб.        

        public Article (string titleOfArticle, string titleOfStore, int price)
        {
            _titleOfArticle = titleOfArticle;
            _titleOfStore = titleOfStore;
            _price = price;
        }

        public string TitleOfArticle
        {
            get
            {
                if (_titleOfArticle != null)
                    return _titleOfArticle;
                else
                    return "***Название товара на задано***";
            }
        }

        public string TitleOfStore
        {
            get
            {
                if (_titleOfStore != null)
                    return _titleOfStore;
                else
                    return "***Название магазина на задано***";
            }
        }

        public int Price => _price;

        public string Show()
        {
            return $"Товар {_titleOfArticle} продается в магазине {_titleOfStore} по цене {_price} рублей.";
        }
    }
}
