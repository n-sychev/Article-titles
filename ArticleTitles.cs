using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace StringConversionFunction;

public static class ArticleTitles
{
    public static string ConvertToArticleCase(string initialString, string exceptionString = "")
    {
        var exceptionStringArray = exceptionString.Split(" ").Select(x => x.ToLowerInvariant());
        
        var splitString = initialString.Split(" ").Select((item, index) =>
        {
            if (index == 0 || !exceptionStringArray.Contains(item))
            {
                return item.Substring(0, 1).ToUpper() + item.Substring(1);
            }
            else
            {
                return item;
            }
        });

        return string.Join(" ", splitString);

        // List<StringBuilder> splitInitialString = new List<StringBuilder>();

        // initialString.Split(' ').ToList().ForEach(x => splitInitialString.Add(new StringBuilder(x)));

        // string[] splitExceptionString = exceptionString.Split(' ');

        // splitInitialString[0].Insert(0, char.ToUpper(splitInitialString[0].ToString().First())).Remove(1,1);

        // for (int i = 1; i < splitInitialString.Count; i++)
        // {
        //     splitInitialString[i] = new StringBuilder(splitInitialString[i].ToString().ToLower());

        //     if (!splitExceptionString.Contains(splitInitialString[i].ToString().ToLower()))
        //     {
        //         splitInitialString[i].Insert(0, char.ToUpper(splitInitialString[i].ToString().First())).Remove(1,1);
        //     }
        // } 
        
        // StringBuilder result =  new StringBuilder("");

        // splitInitialString.ForEach(x => result.AppendFormat(" " + x.ToString()));

        // return result.Remove(0, 1).ToString();
    }
}