using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.Activity
{
    public class Service
    {

        public static DayActivity.Activity.Model[] GetClients(DateTime startdate, DateTime enddate)
        {
            var Activity = new[]
            {
                new DayActivity.Activity.Model
                {
                    Client = new []
                    {
                        new DayActivity.Activity.Clients.Model
                        {
                            Aproval = false,
                            Name = "Cliente 1",
                            ClientId = 1,
                            Time = 7,
                            Product = new[]
                            {
                                new DayActivity.Activity.Clients.Products.Model
                                {
                                    Aproval = false,
                                    Name = "Produto 1",
                                    Time = 7,
                                    ProductId = 1,
                                    Campaign = new []
                                    {
                                        new DayActivity.Activity.Clients.Products.Campaigns.Model
                                        {
                                            Aproval = false,
                                            Name = "Campanha 1",
                                            Time = 7,
                                            CampaingId = 3,
                                            Job = new[]
                                            {
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 1",
                                                    Time = 7
                                                },
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 2",
                                                    Time = 7
                                                }
                                            }
                                        },
                                        new DayActivity.Activity.Clients.Products.Campaigns.Model
                                        {
                                            Aproval = false,
                                            Name = "Campanha 2",
                                            Time = 7,
                                            CampaingId = 4,
                                            Job = new[]
                                            {
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 3",
                                                    Time = 7
                                                },
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 4",
                                                    Time = 7
                                                }
                                            }
                                        }
                                    }
                                },
                                new DayActivity.Activity.Clients.Products.Model
                                {
                                    Aproval = false,
                                    Name = "Produto 2",
                                    Time = 7,
                                    ProductId = 2
                                }
                            }
                        },
                        new DayActivity.Activity.Clients.Model
                        {
                            Aproval = false,
                            Name = "Cliente 2",
                            ClientId = 2,
                            Time = 7,
                            Product = new[]
                            {
                                new DayActivity.Activity.Clients.Products.Model
                                {
                                    Aproval = false,
                                    Name = "Produto 1",
                                    ProductId = 3,
                                    Time = 7,
                                    Campaign = new []
                                    {
                                        new DayActivity.Activity.Clients.Products.Campaigns.Model
                                        {
                                            Aproval = false,
                                            Name = "Campanha 1",
                                            Time = 7,
                                            CampaingId = 1,
                                            Job = new[]
                                            {
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 1",
                                                    Time = 7
                                                },
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 2",
                                                    Time = 7
                                                }
                                            }
                                        },
                                        new DayActivity.Activity.Clients.Products.Campaigns.Model
                                        {
                                            Aproval = false,
                                            Name = "Campanha 2",
                                            Time = 7,
                                            CampaingId = 2,
                                            Job = new[]
                                            {
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 3",
                                                    Time = 7
                                                },
                                                new DayActivity.Activity.Clients.Products.Campaigns.Jobs.Model
                                                {
                                                    Aproval = false,
                                                    Name = "Trabalho 4",
                                                    Time = 7
                                                }
                                            }
                                        }
                                    }
                                },
                                new DayActivity.Activity.Clients.Products.Model
                                {
                                    Aproval = false,
                                    Name = "Produto 2",
                                    ProductId = 3,
                                    Time = 7
                                }
                            }
                        }
                    },
                    Date = new DateTime(2019, 09, 01),
                    Holding = "Luan",
                    Department = "Financeiro"
                 }
            };

            return Activity.Where(x => x.Date >= startdate && x.Date <= enddate).ToArray();
        }

    }
}