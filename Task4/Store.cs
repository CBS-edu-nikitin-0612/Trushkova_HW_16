namespace Task4
{
    internal class Store
    {
        private Article[] _articleArray;

        public Store(int length)
        {
            _articleArray = new Article[length];
        }

        public int CountOfArticles { get { return _articleArray.Length; } }    

        public Store(params Article[] articleArray)
        {
            this._articleArray = articleArray;
        }
        
        public Article this[int index]
        {
            get { return _articleArray[index]; }
            set { _articleArray[index] = value; }
        }

        public string this[string index]
        {
            get
            {
                Article articleCheck = CheckExist(index);
                if (articleCheck != null)
                {
                    return articleCheck.Show();
                }
                else
                { 
                    return "Такого товара нет."; 
                }
            }
        }

        private Article CheckExist(string title)
        {
            for (int i = 0; i < _articleArray.Length; i++)
            {
                if (_articleArray[i].TitleOfArticle == title.Trim())
                    return _articleArray[i];
            }
            return null;
        }
    }
}
