using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AntLifeLibrary.Poli
{
    public abstract class Basebody
    {
        public Basebody()
        {
        }

        public Basebody(string name, float longitude, float latitute)
        {
            Name = name;
            Longitude = longitude;
            Latitute = latitute;
        }

        public virtual string Name { get; set; }
        public virtual float Longitude { get; set; }
        public virtual float Latitute { get; set; }

        public virtual void CreateBase(string Name, float Longitude, float Latitude)
        {
            Debug.WriteLine("Basebody - Name: " + Name);
            Debug.WriteLine("Basebody - Localization: " + Longitude + " | " + Latitude);
        }

        public abstract void CreateDefense(int Val);
    }
}
