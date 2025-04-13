using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18___III___w7___BOX
{
    public class Box
    {
        private double lenght;
        private double width;
        private double hight;

        private double shir;

        public double Shir
        {
            get { return shir; }
            set { shir = value; }
        }


        public Box(double lenght, double width, double hight)
        {
            this.lenght = lenght;
            this.width = width;
            this.hight = hight;
        }

       
        public void Obem()
        {
            Console.WriteLine(this.hight*this.width*this.lenght);
        }
        
        public double Volume()
        {
            return this.lenght * this.hight * this.width;
        }


        public override string ToString()
        {
            return $"The box have lenght: {this.lenght},width: {this.width}, hight: {this.hight}";
        }


    }
}
