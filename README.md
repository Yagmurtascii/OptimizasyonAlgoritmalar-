# Optimizasyon Algoritmaları

## Genel Bakış
Bir problemde belirli koşullar altında mümkün olan alternatifler içinden en iyisini seçme işlemidir. Optimizasyon problemleri için birçok algoritma önerilmiştir. Bu proje kapsamında nümerik araştırma metotları ve sezgisel tabanlı bölgesel iniş yöntemi kullanılır.

- Nümerik Araştırma Metotları
   * En Dik İniş Algoritması
     ![Ekran Alıntısı](https://github.com/Yagmurtascii/OptimizasyonAlgoritmalar-/assets/64540298/0a641cd9-ef17-484b-af27-b9888c251af5)

   * Eşlenik Gradyenit Algoritması
     ![6](https://github.com/Yagmurtascii/OptimizasyonAlgoritmalar-/assets/64540298/60ea5002-c569-499c-a54c-f34518d37b0d)

     Kullanıcında 3 değişkenli fonksiyon girdisi alınır. Başlangıç değerleri, durdurma kriteri (hata toleransı) ve 4. adımda hesaplanması beklenen adım büyüklüğü bu uygulama kapsamında kullanıcıdan alınır.

- Sezgisel Tabanlı Bölgesel İniş Yöntemi
   * Isıl İşlem Algoritması
     ![7](https://github.com/Yagmurtascii/OptimizasyonAlgoritmalar-/assets/64540298/938555f9-594c-49f7-9aa9-48253eda7ebf)

     Bu uygulama bazında komşu ifade belirlerken alt ve üst sınırlar dikkate alınır. Alt sınırın %5 i ve üst sınırın %5 hesaplanır ve bu değerler arasında bulunan random bir yapı seçilir.

     Isıl işlem algoritmasında f(x1,x2)= (x1)^2+ (x2)^2 dikkate alınır. Soğutma tarifesi vardır. Bu soğutma tarifesi ile T değerimiz güncellenir. Bu tarifenin belirlenmesi için kullanıcıdan alpha girdisi alınır.

## Kullanılan Kütüphane

- MathNet Symbolics: Kısmi türev alma ve değerlere göre hesaplamada kullanılan kütüphanelerdir.

 <p align="center">
       <img width=200 src="https://avatars.githubusercontent.com/u/97860?v=4"></p>


## Arayüz Tasarımları

- Genel Arayüz
  <p align="center">
       <img src="https://github.com/Yagmurtascii/OptimizasyonAlgoritmalar-/assets/64540298/9bc0f37c-4285-484a-a241-9689ae56a11b"></p>


- Nümerik Araştırma Metotları Arayüzü
   <p align="center">
       <img src="https://github.com/Yagmurtascii/OptimizasyonAlgoritmalar-/assets/64540298/88147240-a012-4ce2-8a26-93520a617796"></p>


- Sezgisel Tabanlı Bölgesel İniş Yöntemi
   <p align="center">
       <img src="https://github.com/Yagmurtascii/OptimizasyonAlgoritmalar-/assets/64540298/51248e69-75e1-42a6-b51e-6e87bbf90804"></p>

