using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadspringLib
{
    public class DivNumber
    {
        public delegate void SendMessagesHandler(MessagesArgs msgArgs);
        public SendMessagesHandler ViewMessages;

        public List<string> IsDivisable(int start, int end)
        {
            List<string> messages = new List<string>();
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                     messages.Add("fizzbuzz");
                else if (i % 3 == 0)
                      messages.Add("fizz");
                else if (i % 5 == 0)
                     messages.Add("buzz");
                else
                    messages.Add(i.ToString());

            }
            return messages;
        }

        public void RunIsDivisable(int start, int end)
        {
            int index = 0;

            List<string> messages = new List<string>();
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    messages.Add("fizzbuzz");
                else if (i % 3 == 0)
                    messages.Add("fizz");
                else if (i % 5 == 0)
                    messages.Add("buzz");
                else
                    messages.Add(i.ToString());

                //The event is raised every 1000 rows ans then it cleans the List object
                index = i;
                if (index % 1000 == 0)
                {   
                    MessagesArgs newMsg = new MessagesArgs() { messagesToShow = messages };
                    ViewMessages(newMsg);
                    messages.Clear();   
                }
            }

            if (messages.Count > 0)
            {
                MessagesArgs newMssg = new MessagesArgs() { messagesToShow = messages };
                ViewMessages(newMssg);
            }
        }

    }


    public class MessagesArgs : EventArgs
    {
        public List<string> messagesToShow { get; set; }
    }
}
