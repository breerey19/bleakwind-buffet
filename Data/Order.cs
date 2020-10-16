/*
 * Author: Bree Reynoso
 * Class name: Order.cs
 * Purpose: Used to set up order information: total, subtotals, tax, sales tax rate,  order number, and update changed properties.
 * Includes property and IOrderItem changes for each item added or removed and updates totals (Price, calories, etc.)
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<IOrderItem> OrderItems = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => OrderItems.ToArray();


        public Order()
        {
            
            NextOrderNumber++;
        }

        private double subtotal;

        /// <summary>
        /// Adds item to order
        /// </summary>
        public void Add(IOrderItem item)
        {
            subtotal += item.Price;
            calorieTotal += item.Calories;
            OrderItems.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));

        }


        /// <summary>
        /// Adds item to order
        /// </summary>
        public void Remove(IOrderItem item)
        {
            subtotal -= item.Price;
            calorieTotal -= item.Calories;
            OrderItems.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
        }


        private double salesTaxRate = 0.12;
        public double SalesTaxRate
        {
            get{ return salesTaxRate; }
            set
            { 
                if(salesTaxRate != 0.12)
                {
                    salesTaxRate = value;
                }
            }

        }

        private static int NextOrderNumber = 1;

        public double Subtotal => subtotal;


        
        public double Tax
        {
            get { return SalesTaxRate * Subtotal; }
        }

        
        public double Total
        {
            get { return Subtotal + Tax; }
        }

        public int Number => NextOrderNumber;

        private uint calorieTotal;
        public uint Calories
        {
            get
            {
                return calorieTotal;
            }
        }





    }
}


