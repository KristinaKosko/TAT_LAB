using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    [TestFixture]
    public class SearchArticlesTests
    {
        JournalPage journalPage = new JournalPage();
        List<string> articlesNames = new List<string>();
        List<string> foundArticles = new List<string>();
        List<string> words = new List<string>();
        List<string> wordsToSearch = new List<string>();

        [Test]
        [TestCaseSource("names")]
        public void SearchTests(string journal)
        {
            Steps.OpenJournal(journal);
            articlesNames = journalPage.GetJournalArticlesNames();
            foreach (var article in articlesNames)
            {
                words = StepsForSearch.GetWordsOfArticleName(article);
                wordsToSearch = StepsForSearch.GetWordsToSearch(words);
                string request = StepsForSearch.CreateRequest(wordsToSearch);
                foundArticles = StepsForSearch.Search(article, request);
                foreach (var foundArticle in foundArticles)
                {
                    List<string> wordsOfFoundArticle = StepsForSearch.GetWordsOfArticleName(foundArticle);
                    var isFoundRequestedWord = StepsForSearch.CountMatchedWords(wordsOfFoundArticle, request);
                    Assert.IsTrue(isFoundRequestedWord >= 1, $"Search is failed in article {foundArticle}, no matches found on request: {request}");
                }
                WebDriver.Driver.Navigate().Back();
            }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
