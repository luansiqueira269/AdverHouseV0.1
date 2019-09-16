using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTesteAd.Domain.Activity
{
    public class Service
    {

        public static Clients.Model[] GetClients(DateTime startdate, DateTime enddate)
        {
            var Clients = new[]
            {
                new Clients.Model
                {
                    Campaign = new []
                    {
                        new Clients.Campaigns.Model
                        {
                            Aproval = false,
                            Name = "Campanha 1",
                            Time = 7,
                            Holding = "Luan"
                        },
                        new Clients.Campaigns.Model
                        {
                            Aproval = false,
                            Name = "Campanha 1",
                            Time = 7,
                            Holding = "Luan"
                        }
                    },
                    Product = new[]
                    {
                        new Clients.Products.Model
                        {
                            Aproval = false,
                            Name = "Produto 1",
                            Time = 7,
                             Holding = "Luan"
                        },
                        new Clients.Products.Model
                        {
                            Aproval = false,
                            Name = "Produto 2",
                            Time = 7,
                             Holding = "Luan"
                        }
                    },
                    Job = new[]
                    {
                        new Clients.Jobs.Model
                        {
                            Aproval = false,
                            Name = "Trabalho 1",
                            Time = 7,
                            Holding = "Luan"
                        },
                        new Clients.Jobs.Model
                        {
                            Aproval = false,
                            Name = "Trabalho 1",
                            Time = 7,
                            Holding = "Luan"
                        }
                    },
                   Date = new DateTime(2019, 09, 01),
                        Aproval = false,
                        Name = "Cliente 1",
                        Holding = "Luan"
                 },
                new Clients.Model
                {
                    Campaign = new []
                    {
                        new Clients.Campaigns.Model
                        {
                            Aproval = false,
                            Name = "Campanha 1",
                            Time = 7,
                            Holding = "Luan"
                        },
                        new Clients.Campaigns.Model
                        {
                            Aproval = false,
                            Name = "Campanha 1",
                            Time = 7,
                            Holding = "Luan"
                        }
                    },
                    Product = new[]
                    {
                        new Clients.Products.Model
                        {
                            Aproval = false,
                            Name = "Produto 1",
                            Time = 7,
                             Holding = "Luan"
                        },
                        new Clients.Products.Model
                        {
                            Aproval = false,
                            Name = "Produto 2",
                            Time = 7,
                             Holding = "Luan"
                        }
                    },
                    Job = new[]
                    {
                        new Clients.Jobs.Model
                        {
                            Aproval = false,
                            Name = "Trabalho 1",
                            Time = 7,
                            Holding = "Luan"
                        },
                        new Clients.Jobs.Model
                        {
                            Aproval = false,
                            Name = "Trabalho 1",
                            Time = 7,
                            Holding = "Luan"
                        }
                    },
                   Date = new DateTime(2019, 09, 02),
                        Aproval = false,
                        Name = "Cliente 1",
                        Holding = "Luan"
                 }
            };

            return Clients.Where(x => x.Date >= startdate && x.Date <= enddate).ToArray();
        }

    }
}