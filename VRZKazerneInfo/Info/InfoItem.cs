using System;

namespace VRZKazerneInfo
{
    /// <summary>
    /// Info item for MQTTUpdater.
    /// Each update will supply the GUI with info objects
    /// </summary>
    public abstract class InfoItem
    {
        private string infoToDisplay { get; set; }
        public abstract void updateGui(MainWindow window);
    }
}

