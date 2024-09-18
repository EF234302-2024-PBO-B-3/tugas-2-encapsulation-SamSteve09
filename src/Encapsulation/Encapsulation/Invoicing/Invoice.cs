using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Invoicing
{
    public class Invoice
    {
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private double _price;
        public string PartNumber 
        {
            get {  return _partNumber; }
            set { _partNumber = value; }
        }
        public string PartDescription
        {
            get { return _partDescription; }
            set { _partDescription = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set 
            {
                if (value < 0) value = 0;
                _quantity = value; 
            }
            
        }
        public double Price
        {
            get { return _price; }
            set 
            {
                if (value < 0) value = 0.0;
                _price = value; 
            }
        }

        public Invoice(string Num, string Des, int Qua, double Pri)
        {
            PartNumber = Num;
            PartDescription = Des;
            Quantity = Qua;
            Price = Pri;
        }
        public double GetInvoiceAmount()
        {
            double total = this.Price * this.Quantity;
            return total;
        }
    }

}
