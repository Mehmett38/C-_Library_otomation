using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_08_WindowsForm_Combobox
{
    public static class DataBase
    {
        public static List<Urun> sanalDatabase = new List<Urun>()
        {
            new Urun(){
            ID = 1,
            urunAdi = "Bir Ömür Nasıl Yaşanır",
            urunResim = @"\birOmur.jpg",
            kategori = "Roman",
            stokAdet = 1000,
            yazar = "İlber Ortaylı",
            aciklama = @"İlber Ortaylı, yediden yetmişe herkesin faydalanacağı,
bilge şahsiyetinden ve yaşam tecrübesinden süzülen tavsiyelerden 
oluşan bir eserle karşımızda. İlber Hoca bu kitapta, bir insanın,
çocukluktan itibaren hayatın hemen her alanında ihtiyaç duyacağı
çözümleri nasıl bulabileceğini örnekler vererek anlatıyor.
“Herkes kendi talihinin mimarıdır” sözünü hatırlatarak,
kendi yolunu çizmenin ne anlama geldiğini tüm kritik 
noktalarıyla yorumluyor."},

            new Urun(){
            ID = 2,
            urunAdi = "Olasılıksız",
            urunResim = @"\olasılıksız.jpg",
            kategori = "Bilim Kurgu",
            stokAdet = 2000,
            yazar = "Adam Fawar",
            aciklama = "Şizofren bir kumarbazın Rus mafyası olan wayne ile maceraları :)"},

            new Urun(){
            ID = 3,
            urunAdi = "Tesla",
            urunResim = @"\tesla.jpg",
            kategori = "Biyografi",
            stokAdet = 500,
            yazar = "Nikola Tesla",
            aciklama = "Elektrik elektroniğin babasının hayat hikayesi"
            }
        };
        
    }
}
