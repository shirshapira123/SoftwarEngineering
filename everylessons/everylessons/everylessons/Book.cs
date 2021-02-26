using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Book
    {
        string name, author;
        double price;
        bool isExist;
        public Book(string name, string author, double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.isExist = true;
        }
        public string GetName() => name;
        public string GetAuthor() => author;
        public double GetPrice() => price;
        public bool GetIsExist() => isExist;
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }   
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void SetIsExist(bool isExist)
        {
            this.isExist = isExist;
        }
        public override string ToString() => $"\nname: {name}\nauthor: {author}\nprice: {price}\nis exist: {isExist}\n------------------";
        
    }
}
