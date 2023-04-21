﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DTO
{
    public class ProductInBillDTO
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public float total { get; set; }
        public byte[] Image { get; set; }
        public ProductInBillDTO()
        {

        }
        public void getProductInBillDTO(string productID, string productName,float price, int quantity, float total, byte[] image)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.total = total;
            this.Image = image;
        }
    }
}