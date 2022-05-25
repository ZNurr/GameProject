using GameProject;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Abstract;


GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer
    {
        Id = 1,
        BirthYear = 1994,
        FirstName = "NUR",
        LastName = "AK",
        TcNo = 12345
    });

CampaignManager campaign = new CampaignManager();
    campaign.Add(new Campaign
    {
        CampaignId = 1,
        CampaignName = "Bayram Kampanyasi",
        CampaignPercent = 50
    });

SaleManager saleManager = new SaleManager();
((ISaleService)saleManager).Add(new Sales 
    {
        CampaignId = 1,
        SaleId = 1,
        SalePrice = 200
    });
Game game = new Game
{
    GameName = "FIFA22",
    GameUnitPrice = 500
};
Gamer gamer = new Gamer
{
    FirstName="Nur",
    LastName="AK"
};

SaleManager _ = new SaleManager();
saleManager.Buy(game);
saleManager.Buy(game, gamer);
saleManager.BuyDiscount(game, gamer);