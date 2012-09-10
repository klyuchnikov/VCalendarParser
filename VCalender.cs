using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VCalendarParser
{
    public class VCalender
    {
        private List<VEvent> _listEvents;
        public VEvent[] AllEvents { get { return _listEvents.ToArray(); } }


        //VERSION:1.0
        private float _version;
        public float VERSION { get { return _version; } }

        //PRODID:-//Microsoft Corporation//Outlook 14.0 MIMEDIR//EN

        private string _prodid;
        public string PRODID { get { return _prodid; } }

        /// <summary>
        /// Получение экземпляра класса  VCalender из массива строк
        /// </summary>
        /// <param name="allText">Массив строк</param>
        /// <returns>Экземпляр класса VCalender</returns>
        public static VCalender Load(string[] allText)
        {
            return new VCalender();
        }
    }
}
