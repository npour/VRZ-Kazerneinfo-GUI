using System;

namespace VRZKazerneInfo
{
    public class MqttMessageParsingException : Exception
    {
        public MqttMessageParsingException()
        {
        }

        public MqttMessageParsingException (string message): base(message)
        {
        }
    }
}

