using System;

namespace VRZKazerneInfo
{
    /// <summary>
    /// Mqtt message parsing exception.
    /// </summary>
    public class MqttMessageParsingException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VRZKazerneInfo.MqttMessageParsingException"/> class.
        /// </summary>
        public MqttMessageParsingException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VRZKazerneInfo.MqttMessageParsingException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public MqttMessageParsingException (string message): base(message)
        {
        }
    }
}

