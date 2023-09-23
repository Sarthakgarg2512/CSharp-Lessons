using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day3
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
    }
        public interface IPayments
        {
            void Makepayment(float amount);
        }
        internal class Whatsapp : IMessageService, IPayments
        {
            public void DeleteMessage()
            {
                Console.WriteLine("Method not Implemented");
            }
            public void Makepayment(float amount) 
        {
            Console.WriteLine($"Paid Amount {amount}"); 
        }
            public void ReceiveMessage()
            {
                Console.WriteLine("Method not Implemented");
            }
            public void SendAudioMessage(string message)
            {
                Console.WriteLine("Method not Implemented");
            }
            public void SendMessage(string message)
            {
                Console.WriteLine("Method not Implemented");
            }
            //public abstract void SendVideoMessage(string message);
            public void SendVideoMessage(string message)
            {
                Console.WriteLine("Method not Implemented");
            }
        }
        //End of class
        public class MessageTester
        {
            public static void TestOne()
            {
                IMessageService messageService = new Whatsapp();
                messageService.SendMessage("hello");
                messageService.ReceiveMessage();
            }


        }

    }

