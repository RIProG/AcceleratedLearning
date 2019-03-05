using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static HemNet_Azure.Test.TrelloClasses;

namespace HemNet_Azure.Test
{
    class TrelloService
    {
        private async Task<string> Get(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }


        private async Task<string> Post(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.PostAsync(url, null))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }

        public async Task<ICollection<TrelloRoot>> GetAllBoards()
        {

            string page = $"https://api.trello.com/1/members/me/boards?key=66b94baf3e4dfdfa2688852ffdd7b7ef&token=f03995d5b7689ae9811d2f5b23b56ed96042dd7dd1839a6b8247b1a7e12528e9";

            var trello = new TrelloService();

            var result = await trello.Get(page);
            return JsonConvert.DeserializeObject<ICollection<TrelloRoot>>(result);

        }

        public async Task<ICollection<TrelloRoot>> GetAllListsForBoard(string board)
        {
            string page = $"https://api.trello.com/1/boards/{board}/lists?key=66b94baf3e4dfdfa2688852ffdd7b7ef&token=f03995d5b7689ae9811d2f5b23b56ed96042dd7dd1839a6b8247b1a7e12528e9";

            var trello = new TrelloService();

            var result = await trello.Get(page);
            return JsonConvert.DeserializeObject<ICollection<TrelloRoot>>(result);
        }

        public async Task CreateACardOnAList(string list, string name, string desc)
        {
            string page = $"https://api.trello.com/1/cards?name={name}&idList={list}&keepFromSource=all&key=66b94baf3e4dfdfa2688852ffdd7b7ef&token=f03995d5b7689ae9811d2f5b23b56ed96042dd7dd1839a6b8247b1a7e12528e9&desc={desc}";

            var trello = new TrelloService();

            var result = await trello.Post(page);
        }
    }
}
