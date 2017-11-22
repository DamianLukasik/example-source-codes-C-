using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Eventy_test001
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaManager amgr = new AgendaManager();
            SMSSender sms = new SMSSender();

            amgr.AddedAgenda += sms.OnAddedAgenda;
            amgr.AddedAgendaShorter += sms.OnAddedAgendaShorter;

            amgr.AddAgenda(new Agenda()
            {
                AgendaTime = DateTime.Now.AddDays(2),
                AgendaName = "Blade Runner"
            });
            
            Console.ReadKey();
        }
    }

    public class AgendaManager
    {
        public delegate void AddedAgendaEventHandler(object o, AgendaEventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;

        //EventHandler
        //EventHandler<TEventArgs>
        public event EventHandler<AgendaEventArgs> AddedAgendaShorter;
        
        protected virtual void OnAddedAgenda(Agenda newAgenda)
        {
            if (AddedAgenda != null)
                AddedAgenda(this, new AgendaEventArgs() { Agenda = newAgenda });
        }

        protected virtual void OnAddedAgendaShorter(Agenda newAgenda)
        {
            if (AddedAgendaShorter != null)
                AddedAgendaShorter(this, new AgendaEventArgs() { Agenda = newAgenda });
        }

        public void AddAgenda(Agenda newAgenda)
        {
            Console.WriteLine("AddAgenda: Zaczynam dodawać...");
            OnAddedAgenda(newAgenda);
            Thread.Sleep(3000);
            OnAddedAgendaShorter(newAgenda);
            Console.WriteLine("AddAgenda: skończyłem dodawać...");

        }
    }

    public class Agenda
    {
        public DateTime AgendaTime { get; set; }
        public string AgendaName { get; set; }
    }

    public class SMSSender
    {
        public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS Sender: SMS was send!!! Data: "+ e.Agenda.AgendaTime+" Tytuł: "+e.Agenda.AgendaName);
        }

        public void OnAddedAgendaShorter(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS Sender Short: SMS was send!!! Data: " + e.Agenda.AgendaTime + " Tytuł: " + e.Agenda.AgendaName);
        }
    }

    public class AgendaEventArgs : EventArgs
    {
        public Agenda Agenda { get; set; }
    }
}
