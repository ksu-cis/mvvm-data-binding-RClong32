﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
namespace MVVMDataBinding
{
    // <summary>
    /// The ModelView for a cash register control
    /// </summary>
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that notifies when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Model class for this ModelView
        /// </summary> 
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }

        public int Nickles
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                int quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickles");
            }
        }

        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                int quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }

        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                int quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollar");
            }
        }

        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                int quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollar");
            }
        }


        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                int quantity = value - drawer.Ones;
                if (quantity > 0) drawer.AddBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("One");
            }
        }

        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                int quantity = value - drawer.Twos;
                if (quantity > 0) drawer.AddBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Two");
            }
        }


        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                int quantity = value - drawer.Fives;
                if (quantity > 0) drawer.AddBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Five");
            }
        }

        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                int quantity = value - drawer.Tens;
                if (quantity > 0) drawer.AddBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Ten");
            }
        }

        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                int quantity = value - drawer.Twenties;
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenty");
            }
        }

        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                int quantity = value - drawer.Fifties;
                if (quantity > 0) drawer.AddBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifty");
            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                int quantity = value - drawer.Hundreds;
                if (quantity > 0) drawer.AddBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundred");
            }
        }

    }
}
