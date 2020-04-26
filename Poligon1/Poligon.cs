using System;
using System.Collections.Generic;
using System.Text;

namespace Poligon1
{
    abstract class Poligon
    {
        protected string type;
        public Poligon(string type)
        {
            this.type = type;
        }
       
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public abstract void S();
        public abstract void P(double a ,double b ,double c);
    }
}
