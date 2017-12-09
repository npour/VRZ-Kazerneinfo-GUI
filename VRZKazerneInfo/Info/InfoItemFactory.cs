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

        /// <summary>
        /// Creates and parses the news item from message.
        /// </summary>
        /// <returns>The news item from message.</returns>
        /// <param name="message">Message.</param>
        private static NewsItem createNewsItemFromMessage(byte[] message)
        {
            NewsItem item = new NewsItem ();
            var messageString = System.Text.Encoding.ASCII.GetString (message);
            var splittedString = messageString.Split ('|');
            if (splittedString.Count() != 3) {
                throw new MqttMessageParsingException ("Error at parsing");
            }
            try {
                item.date = DateTime.Parse(splittedString [0]);
            }
            catch (FormatException e) {
                throw new MqttMessageParsingException ("Date could not be parsed");
            }
            item.author = splittedString [1];
            item.message = splittedString [2];
            return item;
        }
    }
}
