

using İlkSınıfÖdev;
using System.ComponentModel;

class program
{
    public static void Main(string[] args)
    {
        Person student1 = new Person();
        student1.Ad = "Ahmet";
        student1.Soyad = "Yıldırım";
        student1.DoğumTarihi = new DateTime(2007, 3, 18);

        student1.studentInfo();

        Person student2 = new Person();
        student2.Ad = "Mahmut";
        student2.Soyad = "Akyüz";
        student2.DoğumTarihi = new DateTime(2008, 3, 18);

        student2.studentInfo();


        Person teacher1= new Person();
        teacher1.Ad = "Ayşe";
        teacher1.Soyad = "Korkma";
        teacher1.DoğumTarihi = new DateTime(1987, 5, 7);

        teacher1.teacherInfo();

        Person teacher2= new Person();
        teacher2.Ad = "Mustafa";
        teacher2.Soyad = "Hayal";
        teacher2.DoğumTarihi = new DateTime(1978, 7, 8);

        teacher2.teacherInfo();








    }















}

