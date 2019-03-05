using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HemNet_Azure.Test
{
    [TestClass]
    public class LabTrello
    {
        [TestMethod]
        public void get_all_boards()
        {
            var ts = new TrelloService();
            var result = ts.GetAllBoards().Result;
        }

        [TestMethod]
        public void get_all_lists_for_a_specific_board()
        {
            var ts = new TrelloService();
            var result = ts.GetAllListsForBoard("5c5be73af778cd0f75e37b5c").Result;
        }

        [TestMethod]
        public void add_a_post_to_a_specific_list()
        {
            var ts = new TrelloService();
            ts.CreateACardOnAList("5c5be73a8051492e43e4a1b4", "en post", "beskrivning").Wait();
        }
    }
}
