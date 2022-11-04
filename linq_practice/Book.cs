using System;
using System.Collections.Generic;
using System.Text;

namespace linq_practice
{
    class Book
    {
        string title;
        string author;
        DateTime dateOfPublish;
        int numberOfPages;
        double price;

        public Book(string title, string author,DateTime dateOfPublish,int numberOfPages,double price)
        {
            if(dateOfPublish > DateTime.Now){
                throw new Exception("Date of publish can't be in the future");}
            if(numberOfPages<1){
                throw new Exception("There is 0 or less pages in the book");}
            if(price<0){
                throw new Exception("Price can't be a negative");}
            this.title = title;
            this.author = author;
            this.dateOfPublish = dateOfPublish;
            this.numberOfPages = numberOfPages;
            this.price = price;
        }

        public string Title { get=>title; set { title = value; } }
        public string Author { get=>author; set { author = value; } }
        public DateTime DateOfPublish { get=>dateOfPublish;
            set
            {
                if (value > DateTime.Now){
                    throw new Exception("Date of publish can't be in the future");}
                dateOfPublish = value;
            }
        }
        public int NumberOfPages { get =>numberOfPages;
            set
            {
                if(value<1){
                    throw new Exception("There is 0 or less pages in the book");}
                numberOfPages = value;
            }
        }
        public double Price { get => price;
            set
            {
                if (value < 0){
                    throw new Exception("Price can't be a negative");}
                price = value;
            }
        }

    }
}
