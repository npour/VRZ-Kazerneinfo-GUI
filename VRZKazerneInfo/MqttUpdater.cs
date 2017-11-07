using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Net;

namespace VRZKazerneInfo
{
    public class MqttUpdater
    {
        private MqttClient client;

        public MqttUpdater()
        {
            // This should be updated by the actual hostname of the MQTT broker
            client = new MqttClient("localhost");
            string clientId = Guid.NewGuid ().ToString ();
            try {
                client.Connect (clientId);
                string[] topics = {"/weather", "/traffic"};
                byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
                client.Subscribe(topics, qosLevels);
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            }
            catch(Exception e) {
                Console.WriteLine ("Could not connect to MQTT Broker");
            }

        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine ("MQTT Received");
        }
      
    }
}

