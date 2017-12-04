using System;
using System.Linq;

namespace VRZKazerneInfo
{
    public class InfoItemFactory
    {
        private InfoItemFactory ()
        {
        }

        public static InfoItem createInfoItem(string topic, byte[] message)
        {
            switch (topic) {
            case "/news":
                return InfoItemFactory.createNewsItemFromMessage (message);
            default:
                throw new NotImplementedException ();
            }
        }

        private static WeatherInfo createWeatherInfoFromMessage(byte[] message)
        {
            //TODO: Implement this method and make up some cool format
            throw new NotImplementedException();
        }

        private BirthdayInfo createBirthdayInfoFromMessage(byte[] message)
        {
            //TODO: Implement this method
            throw new NotImplementedException ();
        }

        private static NewsItem createNewsItemFromMessage(byte[] message)
        {
            NewsItem item = new NewsItem ();
            var messageString = System.Text.Encoding.ASCII.GetString (message);
            Console.WriteLine (messageString);
            /*
            int nullsEncountered = 0;
            int latestIndex = 0;
            var nullByte = new byte { 0 };
            for (int i = 0; i < message.Length; i++) {
                if (message [i] == nullByte) {
                    nullsEncountered += 1;
                    switch (nullsEncountered) {
                    case 1:
                        item.author = System.Text.Encoding.UTF8.GetString ((message.Take (i - 1).ToArray ()));
                        item.date = DateTime.Parse (System.Text.Encoding.UTF8.GetString (message.Skip (i + 1).Take (16).ToArray ()));
                        latestIndex = i + 17;
                        break;
                    case 2:
                        item.message = System.Text.Encoding.UTF8.GetString (message.Skip (17).Take (i - 1).ToArray ());
                        break;
                    }
                }
            }
            */
            return item;
        }
    }
}
