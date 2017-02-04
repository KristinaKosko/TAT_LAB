using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    [TestFixture]
    class SearchArticlesTests
    {
        ArticlesSearcher searcher = new ArticlesSearcher();
        JournalPage journalPage = new JournalPage();
        List<string> articlesNames = new List<string>();
        List<string> foundArticles = new List<string>();
        static List<string> names { get { return DataWorker.GetNamesOfJournals(); } }

        [Test]
        [TestCaseSource("names")]
        public void SearchTests(string journal)
        {
            Steps.OpenJournal(journal);
            articlesNames = journalPage.GetJournalArticlesNames();
            foreach (var article in articlesNames)
            {
                List<string> words = GetWordsOfArticleName(article);
                List<string> wordsToSearch = GetWordsToSearch(words);
                string request = CreateRequest(wordsToSearch);
                searcher.InputSearch(request);
                searcher.GoToSearch();
                foundArticles = journalPage.GetJournalArticlesNames();
                foreach (var foundArticle in foundArticles)
                {
                    List<string> wordsOfFoundArticle = GetWordsOfArticleName(foundArticle);
                    var isFoundRequestedWord = CountMatchedWords(wordsOfFoundArticle, request);
                    Assert.IsTrue(isFoundRequestedWord >= 1, "Search is failed in article {0}, no matches found on request: {1}", foundArticle, request);
                }
                WebDriver.Driver.Navigate().Back();
            }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }

        public int CountMatchedWords(List<string> wordsOfFoundArticle, string request)
        {
            var isFoundRequestedWord = 0;
            foreach (var wordOfFoundArticle in wordsOfFoundArticle)
            {
                if (wordOfFoundArticle == request) isFoundRequestedWord++;
            }
            return isFoundRequestedWord;
        }

        public List<string> GetWordsOfArticleName(string article)
        {
            List<string> words = new List<string>();
            foreach (var word in article.Split(' '))
            {
                words.Add(word);
            }
            return words;
        }

        public List<string> GetWordsToSearch(List<string> words)
        {
            List<string> wordsToSearch = new List<string>();
            wordsToSearch.Add(words.First());
            // wordsToSearch.Add(words[3]);
            return wordsToSearch;
        }

        public string CreateRequest(List<string> wordsToSearch)
        {
            string request = wordsToSearch[0];
            //string request = $"{wordsToSearch[0]}{wordsToSearch[1]}";            
            return request;
        }
    }
}
