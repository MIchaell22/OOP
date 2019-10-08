using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class reis :vodii
    {
        private string datareis;
        private string lastpunct;
        private int kilometraj;
        private int perevezano;
        private int roshid;
        public reis(string datareis, string lastpunct, int kilometraj, int perevezano, int roshid,string name, string prizvit, int pobatcovi,string tablenumber, int oklad)
            :base(name,prizvit,pobatcovi, tablenumber,oklad)
        {
            this.Datareis = datareis;
            this.Lastpunct = lastpunct;
            this.Kilometraj = kilometraj;
            this.Perevezano = perevezano;
            this.Roshid = roshid;
        }
        public string Datareis
        {
            get { return datareis; }
            private set { datareis = value; }
        }

        public string Lastpunct
        {
            get { return lastpunct; }
            private set { lastpunct = value; }
        }

        public int Kilometraj
        {
            get { return kilometraj; }
            private set { kilometraj = value; }
        }

        public int Perevezano
        {
            get { return perevezano; }
            private set { perevezano = value; }
        }
        public int Roshid
        {
            get { return roshid; }
            private set { roshid = value; }
     
            
            
        }
    }

}
