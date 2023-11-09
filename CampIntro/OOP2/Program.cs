using OOP2;

RealCustomer musteri1 = new RealCustomer();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Engin"; 
musteri1.Soyadi = "Demirog";
musteri1.TcNo = "2222222222";

LegalCustomer musteri2 = new LegalCustomer();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "1234567890";


Customer customer1 = new LegalCustomer();
Customer customer2 = new RealCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
