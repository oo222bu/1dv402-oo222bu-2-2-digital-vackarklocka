using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_oo222bu_2_2_digital_vackarklocka
{
    public class AlarmClock
    {
        //Börjar med att initiera variablerna
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        //Skapar deras egenskaper
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _alarmHour = value;
            }
        }
        
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _alarmMinute = value;
            }
        }
        
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }
        
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        public AlarmClock()
            : this(0, 0)
        {

        }

        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {

        }

        //Skapar konstruktorerna som ärver ifrån varandra
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        //Skapar metoderna
        public bool TickTock()
        {
            if (Minute < 59)
            {
                ++Minute;
            }
            else
            {
                Minute = 0;

                if (Hour < 23)
                {
                    ++Hour;
                }
                else
                {
                    Hour = 0;
                }
            }
        
            return Hour == AlarmHour && Minute == AlarmMinute;
        }
        
        public override string ToString()
        {
            return string.Format("{0,5}:{1:00} <{2}:{3:00}>", Hour, Minute, AlarmHour, AlarmMinute);
        }
    }
}
