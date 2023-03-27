using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CourseworkApp.Interfaces;
using CourseworkApp.Models;

namespace CourseworkApp.Services
{
    internal static class APIQuoteService : IQuoteService
    {
        static HttpClient _client;
        static public List<QuoteModel> quotes;
        static public bool quotesReceived = false;


        static APIQuoteService()
        {
            quotes = new List<QuoteModel>();
        }


        static public async void GetQuotesFromAPI()
        {
            var items = new List<QuoteModel>();
            Uri uri = new Uri(Constants.apiEndpoint);
            _client = new HttpClient();

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    HttpResponseMessage response = await _client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        Dictionary<string, object> values = JsonSerializer.Deserialize<Dictionary<string, object>>(result);

                        foreach(var pair in values)
                        {
                            Console.WriteLine("in dictionary");
                            Console.WriteLine(pair.Key);
                            Console.WriteLine(pair.Value);
                        };


                        Console.WriteLine("10");
                        object testt = values["text"];
                        Console.WriteLine(testt.ToString());
                        string quote = values["text"].ToString();
                        Console.WriteLine("11");

                        var stringedAuthor = values["author"].ToString();
                        //Dictionary<string, string> temp = (Dictionary<string, string>)values["author"];
                        Dictionary<string, string> temp = JsonSerializer.Deserialize<Dictionary<string, string>>(stringedAuthor);
                        Console.WriteLine("12");
                        string author = temp["name"];
                        Console.WriteLine("13");

                        APIQuoteService.quotes.Add(new QuoteModel()
                        {
                            Quote = quote,
                            Author = author
                        });
                        Console.WriteLine("14");

                        quotesReceived = true;
                    } else
                    {
                        Console.WriteLine("Unsuccessful response status code from API");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in attempt to get quotes from API");
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        static public QuoteModel GetRandomQuote()
        {
            try
            {
                if (quotesReceived == true)
                {
                    Random random = new Random();
                    int randomValue = random.Next(quotes.Count);
                    QuoteModel randomQuote = quotes[randomValue];
                    return randomQuote;
                } else
                {
                    Console.WriteLine("No quotes have been received from API");
                    return new QuoteModel();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error returning quotes");
                return new QuoteModel();
            }
        }
    }
}
