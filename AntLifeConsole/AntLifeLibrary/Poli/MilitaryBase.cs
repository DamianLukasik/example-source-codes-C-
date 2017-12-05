using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AntLifeLibrary.Poli
{
    public class MilitaryBase : Basebody//dziedziczenie
    {
        public MilitaryBase(int WallResistance)
        {
            this.WallResistance = WallResistance;
        }

        public MilitaryBase(string name, float longitude, float latitute) : base(name, longitude, latitute)
        {
            this.WallResistance = 0;
        }

        public MilitaryBase(string name, float longitude, float latitute, int WallResistance) : base(name, longitude, latitute)
        {
            this.WallResistance = WallResistance;
        }

        public int WallResistance { get; set; }

        //nadpisujemy standardowe budowanie bazy
        public override void CreateBase(string Name, float Longitude, float Latitude)
        {
            //base.CreateBase(Name, Longitude, Latitude);
            Debug.WriteLine("MilitaryBase - Wall resistance: 0");
                  Debug.WriteLine("MilitaryBase - Name: " + Name);
                  Debug.WriteLine("MilitaryBase - Localization: " + Longitude + " | " + Latitude);
        }//polimorfizm dynamiczny

        //przeciążamy tą metodę własną, jeśli chcemy zbudować z murem
        public virtual void CreateBase(string Name, float Longitude, float Latitude, int WallResistance)
        {
            base.CreateBase(Name, Longitude, Latitude);
            Debug.WriteLine("MilitaryBase - Wall resistance: " + WallResistance);
        }//polimorfizm statyczny

        public override void CreateDefense(int Val)
        {
            Debug.WriteLine("MilitaryBase - Defence value is set to: " + Val);
        }
    }
}
