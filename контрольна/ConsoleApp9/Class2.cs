using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
   class vodii
    {
        private string name;
        private string prizvit;
        private int pobatcovi;
        private string tablenumber;
        private int oklad;

        public vodii(string name, string prizvit, int pobatcovi, string tablenumber, int oklad)

        {
            this.Name = name;
            this.Prizvit = prizvit;
            this.Pobatcovi = pobatcovi;
            this.Tablenumber = tablenumber;
            this.Oklad = oklad;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Prizvit
        {
            get { return prizvit; }
            private set { prizvit = value; }
        }

        public int Pobatcovi
        {
            get { return pobatcovi; }
            private set { pobatcovi = value; }
        }

        public string Tablenumber
        {
            get { return tablenumber; }
            private set { tablenumber = value; }
        }
        public int Oklad
        {
            get { return oklad; }
            private set { oklad = value; }
        }
     
    }


}
