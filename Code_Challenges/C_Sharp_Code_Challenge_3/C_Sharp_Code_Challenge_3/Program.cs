using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Code_Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            CricketTeam.Pointscalculation(0);

            //Question 2
            TextAppend.AppendTextToFile();

            //Question 3
            MobilePhone phone = new MobilePhone();
            RingtonePlayer ringtone = new RingtonePlayer();
            ScreenDisplay screen = new ScreenDisplay();
            VibrationMotor vibration = new VibrationMotor();

            phone.OnRing += ringtone.PlayRingtone;
            phone.OnRing += screen.ShowCallerInfo;
            phone.OnRing += vibration.Vibrate;
            phone.ReceiveCall();

        }
    }
}
