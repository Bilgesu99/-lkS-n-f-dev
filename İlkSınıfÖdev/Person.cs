using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkSınıfÖdev
{
    public class Person
    {
        public string ad;
        public string soyad;
        public DateTime doğumTarihi;


        public string Ad //Metotları yazıyoruz.
        {
            get
            {
                return ad;
            }
            set
            {
                ad=value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad=value;
            }
        }

        public DateTime DoğumTarihi
        {
            get
            {
                return doğumTarihi;
            }
            set
            {
                doğumTarihi=value;
            }
        }
        public void teacherInfo()
        {
            Console.WriteLine("Öğretmenin adı ve soyadı " + ad + " " + soyad + " "+ "doğum tarihi: " + doğumTarihi.ToShortDateString());
        }

        public void studentInfo()
        {
            Console.WriteLine("Öğrencinin adı ve soyadı " + ad + " " + soyad + " " + "doğum tarihi: " + doğumTarihi.ToShortDateString());




        }

        
    }



}
