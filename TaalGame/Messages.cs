using System.IO.Ports;

namespace TaalGame
{
    internal class Messages
    {
        public string extractedData { get; set; } = "";
        private string incomingData { get; set; } = "";

        public Messages(SerialPort poort)

        {
            poort.Open();
        }

        public void Receive(SerialPort poort)
        {
            bool messageHandled = false;
            int firstindex;
            int lastindex;
            if (messageHandled == false)
            {
                incomingData += poort.ReadExisting();
                firstindex = incomingData.IndexOf('>');
                lastindex = incomingData.IndexOf('<');
                for (int x = firstindex + 1; x < lastindex; x++)
                {
                    extractedData += incomingData[x];
                }
                messageHandled = true;
            }
        }

        public void clearIncomingData()
        {
            extractedData = "";
            incomingData = "";
        }
    }
}