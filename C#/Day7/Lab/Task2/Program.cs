namespace Task2
{
    internal class Program
    {
        public enum connectionMethod
        {
            Ethernet,
            TokenRing
        }
        public class NIC_Card
        {
            //Manufacture, MAC Address, Type [Ethernet or token ring – use Enumeration here]…
            string _manufaturer;
            string _macAddress;
            connectionMethod _connectionMethod;

            static NIC_Card card = null;

            NIC_Card(string manufacturer, string macAddress, connectionMethod conMethod)
            {
                _manufaturer = manufacturer;
                _macAddress = macAddress;
                _connectionMethod = conMethod;
            }
            NIC_Card()
            {
                _manufaturer = "";
                _macAddress = "";
                _connectionMethod = 0;
            }

            public static NIC_Card getCard()
            {
                if (card == null)
                    card = new NIC_Card();
                return card;
            }
            public static NIC_Card getCard(string manu, string mac, connectionMethod conM)
            {
                if (card == null)
                    card = new NIC_Card(manu, mac, conM);
                return card;
            }

            public override string ToString()
            {
                return $"Manufacturer : {_manufaturer}\nMAC Address : {string.Format("{0}:{1}:{2}:{3}:{4}:{5}",
                                                                            _macAddress.Substring(0, 2),
                                                                            _macAddress.Substring(2, 2),
                                                                            _macAddress.Substring(4, 2),
                                                                            _macAddress.Substring(6, 2),
                                                                            _macAddress.Substring(8, 2),
                                                                            _macAddress.Substring(10,2))}\nConnection Method : {_connectionMethod}";
            }

        }

        static void Main(string[] args)
        {
            //NIC_Card c1 = NIC_Card.getCard(); //first instance
            //NIC_Card c2 = NIC_Card.getCard();
            NIC_Card c3 = NIC_Card.getCard("Microsoft", "A2B4C5D22fA9", connectionMethod.Ethernet);
            Console.WriteLine(c3);

        }
    }
}
