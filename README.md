# Hafıza Oyunu
Bu proje, bir hafıza oyunu uygulamasını içerir. Oyuncuların hafızalarını test etmelerine olanak tanır ve eğlenceli bir deneyim sunar.

# Özellikler
İki oyunculu bir oyun: Oyuncular sırayla resimlerin eşleşen çiftlerini bulmaya çalışır.
Zamanlayıcı: Her oyuncunun belirli bir süre içinde hamle yapması gerekmektedir.
Puanlama sistemi: Oyuncuların doğru eşleşmeler yaptıkça puanları artar. İlk 5 eşleşmeyi tamamlayan oyuncu kazanır.
Renkli arayüz: Canlı renklerle ve kullanıcı dostu bir arayüzle oyun deneyimini geliştirir.
# Kod Özellikleri
Form1.cs: Birinci formun kodlarını içerir. Oyunun ana ekranıdır ve başlangıç ayarlarını yapar.
Form2.cs: İkinci formun kodlarını içerir. Oyunun oynandığı alanı temsil eder ve oyun mantığını yönetir.
ResimDosyalariniGetir(): Proje klasöründeki resim dosyalarını alır ve geçerli resim dosya yollarını bir listede toplar.
ResimleriSec(): Resimlerin eşleşen çiftlerini oluşturur ve karışık bir şekilde diziye yerleştirir.
ResimleriAta(): PictureBox nesnelerine resimleri atar ve eşleşen çiftlerin görüntülenmesini sağlar.
PuanKontrol(): Oyuncuların puanlarını kontrol eder ve oyunun bitip bitmediğini belirler.
TümResimleriGizle(): Oyun alanındaki tüm resimleri gizler ve oyunculara yeni bir oyun için hazırlanmasını sağlar.
  Ayrıca Bu projede, System.Windows.Forms.Timer sınıfı kullanılarak zamanlayıcı işlevselliği sağlanmaktadır.
Zamanlayıcılar, belirli aralıklarla belirli kod parçalarını çalıştırmak için kullanılır. Bu proje içinde zamanlayıcılar,
oyun mekaniğini ve kullanıcı deneyimini yönetmek için kullanılmıştır.
# Görününm
![image](https://github.com/Developper2310/213301069_Hafiza-Oyunu/assets/130366798/131aad0a-3dc0-4bbb-8658-f4a6e34bc8f9)
form1
![image](https://github.com/Developper2310/213301069_Hafiza-Oyunu/assets/130366798/8a262bb8-e11d-4e7c-9a96-1653374a67c0)
form2 başlangıç
![image](https://github.com/Developper2310/213301069_Hafiza-Oyunu/assets/130366798/4479e138-eac1-4f48-ac31-357d245c8d3c)

form2 hatalı seçim

# Nasıl Oynanır?
Oyun başladığında, her oyuncuya sırasıyla resimlerin eşleşen çiftlerini bulması için belirli bir süre verilir.
Oyuncular resimleri tıklar ve eşleşen çiftleri bulmaya çalışırlar.
Doğru eşleşme yapılırsa, oyuncular puan kazanır ve bir sonraki hamleye geçer.
Yanlış eşleşme yapılırsa, sıra diğer oyuncuya geçer ve puanlar korunur.
İlk 5 doğru eşleşmeyi yapan oyuncu oyunu kazanır.
# Nasıl Çalıştırılır?
Proje dosyalarını indirin veya klonlayın.
Visual Studio veya benzeri bir C# geliştirme ortamında projeyi açın.
Proje dosyalarını derleyin ve çalıştırın.
