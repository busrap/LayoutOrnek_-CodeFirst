using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LayoutOrnek1.Models
{
    [Table("Calisanlar")]
    public class Calisan
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Maasi { get; set; }

        /*
       model içerisinde öncelikle tablomuzun içerisinde yer alacak kolonları tanımlıyoruz.istersek  [Table("Calisanlar")] etrıbutte ile tablomuzun sql'de nasıl görüntülenmesi istiyorsak tırnaklar içerisine tablomuzun adını yazıyoruz.yani calisanlar adında bir tablo oluşacak database de

     Daha sonra context class oluşturulrak bağlantı için temeller atılıyor.CalisanlarContext class oluşturuldu
     Daha sonra projemize entity'i insall ediyoruz 
     Daha sonra migrations yapıa bilir.migrations ile oluşan class'ı true yaparak devam ediyoruz.
     Bu işlemden sonra oluşturulan database sql'de görünmeli.
      * **/

    }
}