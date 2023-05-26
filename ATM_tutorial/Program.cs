using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DeltaBanka Hoş Geldiniz");
            Console.WriteLine("Sisteme Giriş Yapılıyor...");

            Console.WriteLine("-----------------------------------------");



            int bankBalance = 250;
            int creditBalance = 0;
            int right = 3;
            int select;

            string userName = "admin";
            string userPassword = "1234";
            string UserTc = "12345678900";
            string UserPhone = "0530 550 50 50";

            string select2;
            string UserCardNumber = "123456789000";
            string tc;
            string phone;


            while (true)
            {
                start:

                Console.WriteLine("1-Kartlı İşlemler");
                Console.WriteLine("2-Kartsız İşlemler");

                Console.WriteLine("-----------------------------------------");
                select = Convert.ToInt32(Console.ReadLine());
                if (select == 1)
                {
                    Console.WriteLine("UserName");
                    string username = Console.ReadLine();
                    Console.WriteLine("password");
                    string password = Console.ReadLine();
                    Console.WriteLine("-----------------------------------------");

                    while (true)
                    {


                        if (username == userName && password == userPassword)
                        {

                            Console.WriteLine("1-Hesabınızdan Para Çekmek");
                            Console.WriteLine("2-Hesabınıza Para Yatırmak");
                            Console.WriteLine("3-Hesaplar Arası Para Transferi");
                            Console.WriteLine("4-Eğitim Ödemeleri veya Harclar");
                            Console.WriteLine("5-Ödemeler veya Faturalar");
                            Console.WriteLine("6-Bilgi Güncelleme");
                            Console.WriteLine("7-Bilgileri Görüntüle");
                            Console.WriteLine("8-Çıkış");
                            Console.WriteLine("-----------------------------------------");
                            


                            select = Convert.ToInt32(Console.ReadLine());

                            switch (select)
                            {
                                case 1:
                                    
                                    Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                                    select2 = Console.ReadLine();
                                    if (select2 == "E" || select2 == "e")
                                    {
                                        break;
                                    }
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("Çekmek İstediğiniz Bakiyeyi Giriniz");
                                    int price = Convert.ToInt32(Console.ReadLine());

                                    if (price <= bankBalance)
                                    {
                                       
                                        bankBalance -= price;
                                        Console.WriteLine(price + "Çekilen Tutar , Kalan Bakiyeniz" + bankBalance);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye...");
                                        break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                                    select2 = Console.ReadLine();
                                    if (select2 == "E" || select2 == "e")
                                    {
                                        break;
                                    }
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("1-Kredi Kartı");
                                    Console.WriteLine("2-Banka Kart");

                                    select = Convert.ToInt32(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        
                                        Console.WriteLine("12 Haneli Kart Numaranızı Girin");
                                        string cardNumber = Console.ReadLine();
                                        if (cardNumber == UserCardNumber)
                                        {
                                            Console.WriteLine("Yüklemek İstediğiniz Bakiyeyi Girin");
                                            select = Convert.ToInt32(Console.ReadLine());
                                            creditBalance += select;
                                            bankBalance -= select;
                                            Console.WriteLine("Kredi Hesabı Güncel Bakiyeniz" + creditBalance);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı Kart Numarası Girdiniz");
                                            break;
                                        }


                                    }
                                    else if (select == 2)
                                    {
                                        
                                        Console.WriteLine("Yüklemek İstediğiniz Tutarı Giriniz");
                                        select = Convert.ToInt32(Console.ReadLine());
                                        bankBalance += select;
                                        Console.WriteLine("Banka Hesabı Güncel Bakiyeniz" + bankBalance);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş Yaptınız");
                                        break;
                                    }

                                    break;
                                case 3:
                                    Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                                    select2 = Console.ReadLine();
                                    if (select2 == "E" || select2 == "e")
                                    {
                                        break;
                                    }
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("1-Başka Hesaba EFT");
                                    Console.WriteLine("2-Başka Hesaba Havale");
                                    select = Convert.ToInt32(Console.ReadLine());
                                    if (select == 1)
                                    {
                                        Console.WriteLine("EFT Numarasını Giriniz");
                                        select2 = Console.ReadLine().ToUpper();
                                        if (select2.Length == 12 && (select2[0] == 'T' && select2[1] == 'R'))
                                        {
                                            {
                                                Console.WriteLine("EFT Edilecek Tutarı Giriniz");
                                                select = Convert.ToInt32(Console.ReadLine());

                                                if (select <= bankBalance)
                                                {
                                                    bankBalance -= select;
                                                    Console.WriteLine("EFT İşlemi Başarılı, Kalan Bakiye" + bankBalance);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz Bakiye...");
                                                    break;
                                                }
                                            }
                                        }
                                    }

                                    else if (select == 2)
                                    {
                                        Console.WriteLine("Havale Numarası Girin");
                                        select = Convert.ToInt32(Console.ReadLine());
                                        if (Convert.ToString(select).Length == 11)
                                        {
                                            Console.WriteLine("Havale Edilecek Tutarı Girin");
                                            select = Convert.ToInt32(Console.ReadLine());
                                            if (select <= bankBalance)
                                            {
                                                bankBalance -= select;
                                                Console.WriteLine("Havale İşlemi Başarılı, Kalan Bakiye" + bankBalance);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz Bakiye...");
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş Yaptın!");
                                        break;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Ana Menüye Dönmek İster Misiniz? (E,H)");
                                    select2 = Console.ReadLine();
                                    if (select2 == "E" || select2 == "e")
                                    {
                                        break;
                                    }

                                    Console.WriteLine("Arayüz Hatalı...");
                                    Console.WriteLine("-----------------------------------------");
                                    break;
                                    
                                case 5:
                                    Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                                    select2 = Console.ReadLine();
                                    if (select2 == "E" || select2 == "e")
                                    {
                                        break;
                                    }
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine("1-Elektrik Faturası");
                                    Console.WriteLine("2-Telefon Faturası");
                                    Console.WriteLine("3-İnternet Faturası");
                                    Console.WriteLine("4-Su Faturası");
                                    Console.WriteLine("5-OGS Faturası");

                                    select = Convert.ToInt32(Console.ReadLine());

                                    if (select == 1)
                                    {
                                        Console.WriteLine("Fatura Tutarını Girin");
                                        select = Convert.ToInt32(Console.ReadLine());
                                        if (bankBalance >= select)
                                        {
                                            bankBalance -= select;
                                            Console.WriteLine("Elektrik Faturası Ödendi, Kalan Bakiyeniz" + bankBalance);
                                            Console.WriteLine("-----------------------------------------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye...");

                                            break;
                                        }
                                    }
                                    else if (select == 2)
                                    {
                                        Console.WriteLine("Fatura Tutarını Giriniz");
                                        select = Convert.ToInt32(Console.ReadLine());
                                        if (bankBalance >= select)
                                        {
                                            bankBalance -= select;
                                            Console.WriteLine("Telefon Faturası Ödendi, Kalan Bakiye" + bankBalance);
                                            Console.WriteLine("-----------------------------------------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye...");
                         
                                            break;
                                        }
                                    }
                                    else if (select == 3)
                                    {
                                        Console.WriteLine("Fatura Tutarını Girin: ");
                                        select = Convert.ToInt32(Console.ReadLine());
                                        if (bankBalance >= select)
                                        {
                                            bankBalance -= select;
                                            Console.WriteLine("İnternet Faturası Ödendi, Kalan Bakiyeniz" + bankBalance);
                                            Console.WriteLine("-----------------------------------------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye...");
                                            

                                            break;
                                        }
                                    }
                                    else if (select == 4)
                                    {
                                        Console.WriteLine("Fatura Tutarını Girin: ");
                                        select = Convert.ToInt32(Console.ReadLine());
                                        if (bankBalance >= select)
                                        {
                                            bankBalance -= select;
                                            Console.WriteLine("Su Faturası Ödendi, Kalan Bakiye" + bankBalance);
                                            Console.WriteLine("-----------------------------------------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye...");
                                            break;
                                        }
                                    }
                                    else if (select == 5)
                                    {
                                        Console.WriteLine("Fatura Tutarını Girin: ");
                                        select = Convert.ToInt32(Console.ReadLine());
                                        if (bankBalance >= select)
                                        {
                                            bankBalance -= select;
                                            Console.WriteLine("OGS Faturası Ödendi, Kalan Bakiye" + bankBalance);
                                            Console.WriteLine("-----------------------------------------");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye...");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş Yaptın!");
                                        Console.WriteLine("-----------------------------------------");
                                        break;
                                    }

                                    break;
                                case 6:
                                   
                                    

                                        Console.WriteLine("1-Ad Soyad");
                                        Console.WriteLine("2-Şifre");
                                        Console.WriteLine("-----------------------------------------");

                                        select = Convert.ToInt32(Console.ReadLine());
                                        if (select == 1)
                                        {
                                            Console.WriteLine("Yeni İsimi Giriniz");
                                            select2 = Console.ReadLine();
                                            userName = select2;
                                            Console.WriteLine("Yeni İsim Kaydedildi.");
                                            Console.WriteLine("-----------------------------------------");
                                        }
                                        else if (select == 2)
                                        {
                                            Console.WriteLine("Yeni Şifre Giriniz");
                                            select2 = Console.ReadLine();
                                            userPassword = select2;
                                            Console.WriteLine("Yeni şifre kaydedildi.");
                                            Console.WriteLine("-----------------------------------------");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yanlış giriş yaptınız.");
                                            break;
                                        }
                                      
                                    
                                    break;
                                case 7:
                                    
                                    
                                        Console.WriteLine("Kullanıcı Adı - " + userName + "\n" +
                                        "Kullanıcı Şifresi - " + userPassword + "\n" +
                                        "Kart Numarası - " + UserCardNumber + "\n" +
                                        "Kredi Bakitesi - " + creditBalance + "\n" +
                                        "Kart Bakiyesi + " + bankBalance);
                                        Console.WriteLine("-----------------------------------------");
                                        
                                    
                                    break;
                                case 8:
                                    goto start;
                                default:
                                    Console.WriteLine("Hatalı Giriş yaptın!");
                                    break;
                            }
                        }
                        else
                        {
                            right--;
                            Console.WriteLine("Hatalı Giriş Yaptınız. Kalan Hakkınız" + right);
                            if (right == 0)
                            {
                                Console.WriteLine("-----------------------------------------");
                                Console.WriteLine("Hesabın Bloke Oldu, Çıkış Yapılıyor..");
                                break;
                            }
                        }
                    }
                }
                else if (select == 2)
                {

                    while (true)
                    {
                        Console.WriteLine("1-CepBank Para çekme");
                        Console.WriteLine("2-Para Yatırma");
                        Console.WriteLine("3-EFT Havale");
                        Console.WriteLine("4-Eğitim Ödemeleri");
                        Console.WriteLine("5-Ödemeler");
                        Console.WriteLine("6-Çıkış Yap");
                        Console.WriteLine("-----------------------------------------");
                        select = Convert.ToInt32(Console.ReadLine());
                        if (select == 1)
                        {
                            Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                            select2 = Console.ReadLine();
                            if (select2 == "E" || select2 == "e")
                            {
                                break;
                            }

                            int cepBankRight = 3;
                            while (true)
                            {
                                Console.WriteLine("TC Numarasını Giriniz");
                                tc = Console.ReadLine();
                                Console.WriteLine("Telefon Numarası Giriniz");
                                phone = Console.ReadLine();
                                Console.WriteLine("Para Miktarını Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("-----------------------------------------");


                                if (tc.Equals(UserTc) && phone.Equals(UserPhone))
                                {
                                    Console.WriteLine(select + " Tutarı " + phone + " Telefon Numaralı ve" + tc + " Kimlik Numaralı Kullanıcıya Gönderildi...");
                                    Console.WriteLine("-----------------------------------------");
                                }
                                else if (cepBankRight == 0)
                                {
                                    Console.WriteLine("Hesabınız 1 saatliğine bloke oldu...");
                                    Console.WriteLine("-----------------------------------------");
                                    goto exit;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş Yaptınız!");
                                    cepBankRight--;
                                    Console.WriteLine("Kalan Hakkınız: " + cepBankRight);
                                    Console.WriteLine("-----------------------------------------");
                                }
                            }

                        }
                        else if (select == 2)
                        {                            Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                            select2 = Console.ReadLine();
                            if (select2 == "E" || select2 == "e")
                            {
                                break;
                            }
                            Console.WriteLine("1-Nakit Ödeme");
                            Console.WriteLine("2-Hesaptan Ödeme");
                            Console.WriteLine("3-Çıkış Yap");
                            Console.WriteLine("-----------------------------------------");
                            select = Convert.ToInt32(Console.ReadLine());
                            if (select == 1)
                            {
                                Console.WriteLine("Kredi Karnı Numarası Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Kimlik No Giriniz");
                                tc = Console.ReadLine();
                                Console.WriteLine("Ödenecek Tutarı Giriniz");
                                select2 = Console.ReadLine();
                                Console.WriteLine("-----------------------------------------");

                                if (tc.Length == 12 && select.ToString().Length == 12)
                                {
                                    Console.WriteLine(select2 + " Tutarı " + select + " Kart Numaralı ve" + tc + " Kimlik Numaralı Kullanıcıya Gönderildi...");
                                    Console.WriteLine("-----------------------------------------");
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı giriş yaptınız!");
                                    break;
                                }

                            }
                            else if (select == 2)
                            {
                                Console.WriteLine("Kredi Karnı Numarası Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Hesap Numaranızı giriniz");
                                select2 = Console.ReadLine();
                                Console.WriteLine("-----------------------------------------");

                                if (select.ToString().Length == 12 && select2.Length == 11)
                                {
                                    Console.WriteLine("Gönderilecek Tutarı Giriniz");
                                    select = Convert.ToInt16(Console.ReadLine());

                                    Console.WriteLine(select + " Tutarı " + select2 + " Hesap Numaralı Kullanıcıya Gönderildi...");
                                    Console.WriteLine("-----------------------------------------");
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı giriş yaptınız!");
                                    break;
                                }

                            }
                            else if (select == 3)
                            {
                                goto start;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş Yaptınız!");
                            }
                        }
                        else if (select == 3)
                        {
                            Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                            select2 = Console.ReadLine();
                            if (select2 == "E" || select2 == "e")
                            {
                                break;
                            }

                            Console.WriteLine("1-Başka Hesaba EFT");
                            Console.WriteLine("2-Başka Hesaba Havale");
                            select = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("-----------------------------------------");
                            if (select == 1)
                            {
                                Console.WriteLine("EFT Numarası Giriniz");
                                select2 = Console.ReadLine().ToUpper();
                                if (select2.Length == 12 && (select2[0] == 'T' && select2[1] == 'R'))
                                {
                                    {
                                        Console.WriteLine("EFT Edilecek Tutarı Giriniz");
                                        select = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("EFT işlemi başarılı, gönderilen EFT numarası" + select2);
                                        Console.WriteLine("-----------------------------------------");
                                    }
                                }
                            }

                            else if (select == 2)
                            {
                                Console.WriteLine("Havale Numarası Giriniz");
                                select2 = Console.ReadLine();
                                if (select2.Length == 11)
                                {
                                    Console.WriteLine("Havale Edilecek Tutarı Giriniz");
                                    select = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Havale İşlemi Başarılı, Gönderilen Havale Numarası" + select2);
                                    Console.WriteLine("-----------------------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş Yaptın!");
                                break;
                            }
                        }
                        else if (select == 4)
                        {
                            Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                            select2 = Console.ReadLine();
                            if (select2 == "E" || select2 == "e")
                            {
                                break;
                            }
                            Console.WriteLine("Sayfa Arızalı...");
                            Console.WriteLine("-----------------------------------------");
                            break;

                        }
                        else if (select == 5)
                        {
                            Console.WriteLine("Ana menüye dönmek ister misiniz? (E,H)");
                            select2 = Console.ReadLine();
                            if (select2 == "E" || select2 == "e")
                            {
                                break;
                            }

                            Console.WriteLine("1-Elektrik Faturası");
                            Console.WriteLine("2-Telefon Faturası");
                            Console.WriteLine("3-İnternet Faturası");
                            Console.WriteLine("4-Su Faturası");
                            Console.WriteLine("5-OGS Faturası");
                            Console.WriteLine("-----------------------------------------");
                            select = Convert.ToInt32(Console.ReadLine());


                            if (select == 1)
                            {
                                Console.WriteLine("Fatura Tutarını Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Fatura No Girin");
                                select2 = Console.ReadLine();

                                Console.WriteLine(select2 + " Nolu Elektrik Faturası Ödendi.");
                                Console.WriteLine("-----------------------------------------");
                            }
                            else if (select == 2)
                            {
                                Console.WriteLine("Fatura Tutarını Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Fatura No Girin");
                                select2 = Console.ReadLine();

                                Console.WriteLine(select2 + " Nolu Elektrik Faturası Ödendi.");
                                Console.WriteLine("-----------------------------------------");
                            }
                            else if (select == 3)
                            {
                                Console.WriteLine("Fatura Tutarını Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Fatura No Girin");
                                select2 = Console.ReadLine();

                                Console.WriteLine(select2 + " Nolu Elektrik Faturası Ödendi.");
                                Console.WriteLine("-----------------------------------------");
                            }
                            else if (select == 4)
                            {
                                Console.WriteLine("Fatura Tutarını Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Fatura No Girin");
                                select2 = Console.ReadLine();

                                Console.WriteLine(select2 + " Nolu Elektrik Faturası Ödendi.");
                                Console.WriteLine("-----------------------------------------");
                            }
                            else if (select == 5)
                            {
                                Console.WriteLine("Fatura Tutarını Giriniz");
                                select = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Fatura No Girin");
                                select2 = Console.ReadLine();

                                Console.WriteLine(select2 + " Nolu Elektrik Faturası Ödendi.");
                                Console.WriteLine("-----------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş Yaptın!");
                                break;
                            }

                        }
                        else if (select == 6)
                        {
                            
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Giriş Yaptınız!");
                        }
                    }
                





            }
                else if (select == 3)
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Giriş Yaptın.");
                }
               
            }
            exit:
            Console.WriteLine("Program Kapatılıyor...");






























        }
    }
}
