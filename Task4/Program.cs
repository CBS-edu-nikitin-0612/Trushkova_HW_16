// See https://aka.ms/new-console-template for more information
using Task4;

Console.WriteLine("Hello, Teacher!");
Article article1 = new Article("Toy", "Lego", 5000);
Article article2 = new Article("Cheese", "MilkStore", 1000);
Article article3 = new Article("Playstation", "CoolOne", 100000);

Store newStore = new Store(article1, article2, article3);

//Вывод на экран информации о всех товарах
for (int i = 0; i < newStore.CountOfArticles; i++)
{
    Console.WriteLine(newStore[i].Show());
}

//Вывод на экран информации о конкретном товаре
while (true)
{
    Console.WriteLine("\nВведите название товара:");

    string? title = Console.ReadLine();

    if (!string.IsNullOrEmpty(title))
    {
        Console.WriteLine(newStore[title]);
    }
    else
    {
        Console.WriteLine("Вы ничего не ввели");
    }
}


