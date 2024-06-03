using StringConversionFunction;

class Program
{
    static void Main()
    {
        Console.WriteLine(ArticleTitles.ConvertToArticleCase("the clash of CLANS", "a an the of"));

        Console.WriteLine(ArticleTitles.ConvertToArticleCase("В шаге ОТ победы", "в от"));
        
        Console.WriteLine(ArticleTitles.ConvertToArticleCase("первый аргумент")); 
    }
}