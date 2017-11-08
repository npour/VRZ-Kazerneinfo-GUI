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
        private List<WeatherInfo> weatherItems;

        public MqttUpdater()
        {
            weatherItems = new List<WeatherInfo> ();
            // This should be updated by the actual hostname of the MQTT broker
            client = new MqttClient("BrokerHostname");
            string[] topics = {"/weather", "/traffic"};
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
            client.Subscribe(topics, qosLevels);
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            switch (e.Topic) {
            case "/weather":
                weatherItems.Add(new WeatherInfo());
                break;
            }
        }
      
    }
}

