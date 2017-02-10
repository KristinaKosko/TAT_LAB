using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class StepsForSearch
    {
        public static List<string> Search(string article, string request)
        {
            ArticlesSearcher searcher = new ArticlesSearcher();
            List<string> articlesNames = new List<string>();
            List<string> foundArticles = new List<string>();
            JournalPage journalPage = new JournalPage();
            searcher.InputSearch(request);
            searcher.GoToSearch();
            foundArticles = journalPage.GetJournalArticlesNames();
            return foundArticles;
        }

        public static int CountMatchedWords(List<string> wordsOfFoundArticle, string request)
        {
            var isFoundRequestedWord = 0;
            foreach (var wordOfFoundArticle in wordsOfFoundArticle)
            {
                if (wordOfFoundArticle == request) isFoundRequestedWord++;
            }
            return isFoundRequestedWord;
        }

        public static List<string> GetWordsOfArticleName(string article)
        {
            List<string> words = new List<string>();
            foreach (var word in article.Split(' '))
            {
                words.Add(word);
            }
            return words;
        }

        public static List<string> GetWordsToSearch(List<string> words)
        {
            List<string> wordsToSearch = new List<string>();
            wordsToSearch.Add(words.First());
            // wordsToSearch.Add(words[3]);
            return wordsToSearch;
        }

        public static string CreateRequest(List<string> wordsToSearch)
        {
            string request = wordsToSearch[0];
            //string request = $"{wordsToSearch[0]}{wordsToSearch[1]}";            
            return request;
        }
    }
}
