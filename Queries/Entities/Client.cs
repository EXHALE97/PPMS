namespace Queries.Entities
{
    public class Client
    {
        public int Id { private set; get; }
        public string Mark { private set; get; }
        public string CardNum { private set; get; }

        public Client(int id, string carMark, string cardNum)
        {
            Id = id;
            Mark = carMark;
            CardNum = cardNum;
        }

        public Client(string carmMrk, string cardNum)
        {
            Mark = carmMrk;
            CardNum = cardNum;
        }
    }
}
