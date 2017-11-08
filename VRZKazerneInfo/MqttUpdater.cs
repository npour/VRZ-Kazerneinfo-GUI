using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net;
using System.Collections.Generic;

namespace VRZKazerneInfo
{
    public class MqttUpdater
    {
        private MqttClient client;
        private MainWindow mainWindow;

        public MqttUpdater(MainWindow mainWindow)
        {
            this.initClient ();
            this.mainWindow = mainWindow;
        }

        /// <summary>
        /// Inits the client.
        /// </summary>
        private void initClient()
        {
            // This should be updated by the actual hostname of the MQTT broker
            client = new MqttClient("localhost");
            string clientId = Guid.NewGuid ().ToString ();
            try {
                client.Connect (clientId);
                string[] topics = {"/weather", "/traffic", "/news"};
                byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, 
                                    MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE,  
                    MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
                client.Subscribe(topics, qosLevels);
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            }
            catch(Exception e) {
                Console.WriteLine (e.Message);
                Console.WriteLine ("Could not connect to MQTT Broker");
            }
        }

        /// <summary>
        /// Receive event for the MQTT topics
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var message = System.Text.Encoding.Default.GetString (e.Message);
            this.mainWindow.updateGuiFromMqtt (e.Topic, message);
            Console.WriteLine ("MQTT Received");
            Console.WriteLine ("Topic: " + e.Topic);
            Console.WriteLine ("Message: " + message);
        }
      
    }
}

