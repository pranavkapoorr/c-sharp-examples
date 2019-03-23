using System;

namespace classes{
    class Car{
        private String name;
        private String price;
        public Car(String name, String price){
            this.name = name;
            this.price = price;
        }
        public String getName(){
            return this.name;
        }
        public String getPrice(){
            return this.price;
        }
    }
    class CarTester{
        static void Main(string[] args){
            Car car1 = new Car("Mercedes","50000");
            Car car2 = new Car("Camaro","35000");
            Console.WriteLine("car-1: {0}, {1}",car1.getName(),car1.getPrice());
            Console.WriteLine("car-2: {0}, {1}",car2.getName(),car2.getPrice());
        }
    }
}
