using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final
{
    class Book:ReadingMaterial 
    {
        private string author;
        private Date publicationDate;

        public Book(string titl,string Auth, Date publication)
        {
            Title = titl;
            Author = Auth;
            PublicationDate = publication;
        }
           
        public string Author
        {
            get { return author; }
            set { author = value;}
        }
        public Date PublicationDate
        {
            get { return publicationDate; }
            set { publicationDate = value; }
        }
        public void Donate()
        {
            Console.WriteLine("Donate the book {0} and Date {1}", author, publicationDate);
        }
        public override void ToString()
        {
            Console.WriteLine("{0}, author is {1}, published on {2}", Title, Author,publicationDate);
            
        }
        ~Book() { }
    }
}
