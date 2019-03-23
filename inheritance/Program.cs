using System;

namespace inheritance {
    class Shape {
        protected int length, width;
        public void setLength(int length){
            this.length = length;
        }
        public void setWidth(int width){
            this.width = width;
        }
    }
    class Square : Shape{
        public int Area(){
            return (length * width);
        }
    }
    class Program {
        static void Main(string[] args) {
            Square sq1 = new Square();
            sq1.setLength(5);
            sq1.setWidth(5);
            Console.WriteLine("area of square: {0}",sq1.Area());
        }
    }
}
