using System;

namespace Delegate_Learn {
    class DelegateLearn {
        public delegate void NoReturnFunc();
        private NoReturnFunc orderDelegate = new NoReturnFunc(BuyFood);

        public void AddFlower(){

            orderDelegate += BuyFlower;
        }

        public void RemoveFlower(){
            orderDelegate -= BuyFlower;
        }

        public void showOrder(){
            orderDelegate();
        }

        public static void BuyFood()
        {
            Console.WriteLine("Buy Food!");
        }
        public static void BuyFlower()
        {
            Console.WriteLine("Buy Flower!");
        }
        public static void BuyCake()
        {
            Console.WriteLine("Buy Cake!");
        }
    }




}