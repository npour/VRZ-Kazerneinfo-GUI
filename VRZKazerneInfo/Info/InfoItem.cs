using System;

namespace VRZKazerneInfo
{
    public abstract class InfoItem
    {
        private string infoToDisplay { get; set; }

        abstract public void parseMessage(string message);
    }
}

