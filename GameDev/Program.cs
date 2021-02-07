using System;

namespace GameDev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Id = 1, Name = "Zula",Price= 50 };
            Product product1 = new Product() { Id = 2, Name = "Call Of Duty",Price= 150 };
            Product product2 = new Product() { Id = 3, Name = "GTA",Price= 70 };
            Product product3 = new Product() { Id = 4, Name = "Pubg",Price= 80 };

            Gamer gamer = new Gamer() {Id=1,Name="Nadide",Surname="Sığırtmaç",UserName="nadissu",NationalityId=20786013636,CreditCardNumber=2468101214,BirthYear=1997 };
            Gamer gamer1 = new Gamer (){ Id = 2, Name = "Funda", Surname = "Baskın", UserName = "ffunda", NationalityId = 4256187953, CreditCardNumber = 789456123100, BirthYear = 1985 };
            Gamer gamer2 = new Gamer() { Id = 2, Name = "Sevgi", Surname = "Saygın", UserName = "ssevgi", NationalityId = 784569321245, CreditCardNumber = 159753489623, BirthYear = 1982 };


            Campaign campaign1 = new Campaign() { GameId = 100, CampaignName = "Yaz Tatili", RateOfDiscount = 10 };
            Campaign campaign2 = new Campaign() { GameId = 200, CampaignName = "Hadi Yine İyisiniz", RateOfDiscount = 25 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);

            Sales sales1 = new Sales() { Product = product1.Name, Gamer = gamer2.UserName };

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(product2, gamer1);
            salesManager.Buy(product, gamer);

            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Save(gamer);
            gamerManager.Save(gamer1);
            gamerManager.Save(gamer2);
            gamerManager.Update(gamer2);

        }
    }
}
