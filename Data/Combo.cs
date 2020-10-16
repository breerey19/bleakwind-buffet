/*
 * Author: Bree Reynoso
 * Class name: Combo.cs
 * Purpose: Used to set up a combo (entree, side, and drink) with discounted price 
 * and updated totals of cost, calories, and customizations
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged 
    {
        //private string DrinkToString;
        private Size DrinkSize;
        private double DrinkPrice;
        private uint DrinkCalories;
        private List<string> DrinkSpecialInstructions;

        private Size SideSize;
        private double SidePrice;
        private uint SideCalories;
        private List<string> SideSpecialInstructions;

        private double EntreePrice;
        private uint EntreeCalories;
        private List<string> EntreeSpecialInstructions;


        public Combo(Entree entree, Side side, Drink drink)
        {
            drink = Drink;
            side = Side;
            entree = Entree;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }


        private Drink Drink
        {
            get { return Drink; }
            set
            {
                //DrinkToString = Drink.ToString;
                DrinkSize = Drink.Size;
                DrinkPrice = Drink.Price;
                DrinkCalories = Drink.Calories;
                DrinkSpecialInstructions = Drink.SpecialInstructions;
            }
        }

        private Side Side
        {
            get { return Side; }
            set
            {
                SideSize = Side.Size;
                SidePrice = Side.Price;
                SideCalories = Side.Calories;
                SideSpecialInstructions = Side.SpecialInstructions;
            }
        }

        private Entree Entree
        {
            get { return Entree; }
            set
            {
                EntreePrice = Entree.Price;
                EntreeCalories = Entree.Calories;
                EntreeSpecialInstructions = Entree.SpecialInstructions;
            }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                price = DrinkPrice + SidePrice + EntreePrice - 1;
            }
        }

        private uint calories;
        public uint Calories
        {
            get { return calories; }
            set
            {
                calories = DrinkCalories + SideCalories + EntreeCalories;
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get { return specialInstructions; }
            set
            {
                specialInstructions.Add(Entree.ToString());
                List<string> entreeList = EntreeSpecialInstructions;
                for (int i = 0; i < entreeList.Count; i++)
                {
                    string item = entreeList[i];
                    specialInstructions.Add(item);
                }

                specialInstructions.Add(Side.ToString());
                List<string> sideList = SideSpecialInstructions;
                for (int i = 0; i < sideList.Count; i++)
                {
                    string item = sideList[i];
                    specialInstructions.Add(item);
                }

                specialInstructions.Add(Drink.ToString());
                List<string> drinkList = DrinkSpecialInstructions;
                for (int i = 0; i < drinkList.Count; i++)
                {
                    string item = drinkList[i];
                    specialInstructions.Add(item);
                }
            }
        }

        //List<string> IOrderItem.SpecialInstructions => ((IOrderItem)Drink).SpecialInstructions;

        //string IOrderItem.ToString => ((IOrderItem)Drink).ToString;

        //Action<object, PropertyChangedEventArgs> IOrderItem.PropertyChanged { get => ((IOrderItem)Drink).PropertyChanged; set => ((IOrderItem)Drink).PropertyChanged = value; }
    }
}


