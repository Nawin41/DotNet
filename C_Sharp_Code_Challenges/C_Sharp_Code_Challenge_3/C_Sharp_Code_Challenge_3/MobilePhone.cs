using System;

namespace C_Sharp_Code_Challenge_3
{
    public class MobilePhone
    {
        public delegate void RingEventHandler();
        public event RingEventHandler OnRing;

        public void ReceiveCall()
        {
            Console.WriteLine("Incoming call...");

            if (OnRing != null)
            {
                OnRing();
            }
        }
    }
}