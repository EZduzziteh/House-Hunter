using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class HouseData
    {

        public int id;
        public String address;
        public string postalCode;
        public string listDate;
        public string NumberOfBedrooms;
        public string numberOfBathrooms;
        public string listPrice;
        public string description;
        public string sellingPrice;
        public string squareFeet;
        public string sellingDate;

        public HouseData(int id, String address, string postalCode, string listDate, string numberOfBedrooms, string numberOfBathrooms, string listPrice, string description, string sellingPrice, string squareFeet, string sellDate)
        {
            this.id = id;
            this.address = address;
            this.postalCode=postalCode;
            this.listDate=listDate;
            this.NumberOfBedrooms=numberOfBedrooms;
            this.numberOfBathrooms=numberOfBathrooms;
            this.listPrice=listPrice;
            this.description=description;
            this.sellingPrice=sellingPrice;
            this.squareFeet=squareFeet;
            this.sellingDate=sellingPrice;
        }


     

    }
}
