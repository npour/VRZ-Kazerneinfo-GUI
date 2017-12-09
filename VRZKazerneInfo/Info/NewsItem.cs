using System;

namespace VRZKazerneInfo
{
    /// <summary>
    /// News item.
    /// Binary format to parse a news message is:
    /// author: variable length ended by \0
    /// date: fixed length 16
    /// message: variable length ended by \0
    /// </summary>
    public class NewsItem : InfoItem
    {
        public string author { get; set; }
        public DateTime date { get; set; }
        public string message { get; set; }

        public NewsItem ()
        {
        }

        public override void updateGui(MainWindow window)
        {
            object[] values = { this.author, this.date.ToString("dd-MM-yyyy"), this.message }; 
            window.newsTabel.newsMessageListStore.AppendValues(values);
        }
}
}
