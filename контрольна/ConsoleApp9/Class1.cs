using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
     class machine
    {
        private string derjnamb;
        private string model;
        private int vantajpidio;
        private int palne;
        private string pripiska;

        public machine(string derjnamb, string model, int vantajpidio, int palne, string pripiska)

        {
            this.Derjnamb = derjnamb;
            this.Model = model;
            this.Vantajpidio = vantajpidio;
            this.Palne = palne;
            this.Pripiska = pripiska;
        }

        public string Derjnamb
        {
            get { return derjnamb; }
            private set { derjnamb = value; }
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public int Vantajpidio
        {
            get { return vantajpidio; }
            private set { vantajpidio = value; }
        }

        public int Palne
        {
            get { return palne; }
            private set { palne = value; }
        }
        public string Pripiska
        {
            get { return pripiska; }
            private set { pripiska = value; }
        }
       
    }
}