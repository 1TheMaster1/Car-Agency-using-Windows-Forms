﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project //Hossam
{//class for cars in stock 
    public class Car
    {
        int id;
        string? model;
        string? make;
        string? color;
        int horsePower;
        string? type;
        int purchasePrice;
        int sellingPrice;
        Bitmap? carImage;
        public static List<Car> carList = new List<Car>();

        //constructor to add a car to the cars file
        public Car(int id, string model, string make, string color, int horsePower, string type, int purchaseprice, int sellingPrice, Bitmap carImage)
        {
            this.id = id;
            this.model = model;
            this.make = make;
            this.color = color;
            this.horsePower = horsePower;
            this.type = type;
            this.purchasePrice = (purchaseprice >= 0) ? purchaseprice : 0;
            this.sellingPrice = (sellingPrice >= purchaseprice) ? sellingPrice : 0;
            this.carImage = carImage;
        }
        public Car() { }

        public int ID {  get { return id; } }
        public string? Model { get { return model; } }
        public string? Make { get { return make; } }
        public string? Color { get { return color; } }
        public int HoursePower { get {  return horsePower; } }
        public string? Type { get { return type; } }
        public int PurchasePrice { get {  return purchasePrice; } }
        public int SellingPrice { get { return sellingPrice; } }
        public Bitmap? CarImage { get {  return carImage; } }
    }
}
