using System;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(2020, 5, 28, 15, 9, 55);
            clock.alarm.Alarm();
        }
    }

    public delegate void clockHandler(object sender, TickEventArgs args);

    public class TickEventArgs
    {
        public DateTime Time
        {
            get; set;
        }
    }

    class alarm
    {
        public event clockHandler onAlarm;
        public event clockHandler onTick;

        public DateTime alarmTime
        {
            get; set;
        }
        public void Alarm()
        {
            TickEventArgs args = new TickEventArgs()
            {
                Time = DateTime.Now
            };
            TimeSpan span;
            while (true)
            {
                onTick(this, args);
                System.Threading.Thread.Sleep(1000);
                span = alarmTime.Subtract(args.Time);
                if (span.TotalSeconds < 1 && span.TotalSeconds > 0)
                    onAlarm(this, args);
            }
        }
    }

    class Clock
    {
        public alarm alarm = new alarm();

        public Clock(int y, int m, int d, int h, int mmm, int s)
        {
            alarm.alarmTime = new DateTime(y, m, d, h, mmm, s);
            alarm.onTick += addTime;
            alarm.onTick += show;
            alarm.onAlarm += ringing;
        }

        public void addTime(object sender, TickEventArgs args)
        {
            args.Time = DateTime.Now;
        }

        public void show(object sender, TickEventArgs args)
        {
            Console.WriteLine("Tick：" + args.Time.ToString("T"));
        }

        public void ringing(object sender, TickEventArgs args)
        {
            Console.WriteLine("Alarm now");
        }
    }
}


