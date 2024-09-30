using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpeechCompetition
{
    internal class Program
    {
        static int participantsCount = 0;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread t = new Thread(EnterSpeechCompetition);
                t.Start(i);
            }
        }

        static void EnterSpeechCompetition(object participantId)
        {
            Monitor.Enter(typeof(Program));
            try
            {
                participantsCount++;
                Console.WriteLine($"Participant {participantId} entered. Total participants: {participantsCount}");
            }
            finally
            {
                Monitor.Exit(typeof(Program));
            }

            Thread.Sleep(1000);
            Monitor.Enter(typeof(Program));

            try
            {
                participantsCount--;
                Console.WriteLine($"Participant {participantId} finished. Total participants: {participantsCount}");
            }
            finally
            {
                Monitor.Exit(typeof(Program));
            }
        }
    }
}
