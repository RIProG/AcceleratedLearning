using EfSamurai.Data;
using EfSamurai.Domain;
using System;
using System.Collections.Generic;

namespace EfSamurai.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ClearDatabase();
            //AddOneSamurai();
            //AddSomeSamurais();
            //AddSomeBattles();
            //AddOneSamuraiWithRelatedData();
            ListAllSamuraiNames();
        }

        private static void ListAllSamuraiNames()
        {
            throw new NotImplementedException();
        }

        private static void ClearDatabase()
        {
            using (var context = new SamuraiContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }


        private static void AddOneSamuraiWithRelatedData()
        {
            var samurai = new Samurai
            {
                Name = "Akakaboto",
                HairStyle = new HairStyle
                {
                    HairStyleName = "Oicho"
                },
                SecretIdentity = new SecretIdentity
                {
                    SecretName = "Japanese Bear"
                },
                Quotes = new List<Quote>()
                {
                    new Quote
                    {
                    Text = "Bare with me!",
                    Category = new QuoteCategory
                    {
                        Name = "Combat phrase"
                    }
                    },
                    new Quote
                    {
                        Text = "I can't bare it!",
                        Category = new QuoteCategory
                        {
                            Name = "Surrendering quote"
                        }
                    }
                },
                SamuraiBattles = new List<SamuraiBattle>()
                {
                    new SamuraiBattle
                    {
                        Battle = new Battle
                        {
                           BattleName = "Third Blood",
                           BattleLog = new BattleLog
                           {
                              BattleLogName = "Third Blood Battlelog",
                              BattleEvents = new List<BattleEvent>()
                              {
                                  new BattleEvent
                                  {
                                      Text = "Number three is the charm, third strike K.O.!",
                                      Summary = "K.O.!",
                                      DateTime = DateTime.Parse("500-02-01")
                                  },
                                  new BattleEvent
                                  {
                                      Text = "Hundred years of battle over",
                                      Summary = "HundredOver",
                                      DateTime = DateTime.Parse("600-10-10")
                                  }
                              }
                           }
                        },
                    },
                    new SamuraiBattle
                    {
                        Battle = new Battle
                        {
                           BattleName = "Fourth Blood",
                           BattleLog = new BattleLog
                           {
                              BattleLogName = "Fourth Blood Battlelog",
                              BattleEvents = new List<BattleEvent>()
                              {
                                  new BattleEvent
                                  {
                                      Text = "Fourth of July strike",
                                      Summary = "USA??",
                                      DateTime = DateTime.Parse("912-07-04")
                                  },
                                  new BattleEvent
                                  {
                                      Text = "Everyone for themselves",
                                      Summary = "Free 4 All",
                                      DateTime = DateTime.Parse("1013-08-01")
                                  }
                              }
                           }
                        },
                    }
                }
            };

            var context = new SamuraiContext();
            context.Samurais.Add(samurai);
            context.SaveChanges();
        }

        private static void AddSomeBattles()
        {
            List<Battle> battles = new List<Battle>()
            {
                new Battle
                {
                    BattleName = "First Blood",
                    BattleLog = new BattleLog
                    {
                        BattleLogName = "First Blood Battlelog",
                        BattleEvents = new List<BattleEvent>()
                        {
                            new BattleEvent
                            {
                                Text = "The first strike was bloody",
                                Summary = "Bloody",
                                DateTime = DateTime.Parse("250-06-05")
                            },
                            new BattleEvent
                            {
                                Text = "Two years later one side surrendered",
                                Summary = "Surrender",
                                DateTime = DateTime.Parse("252-09-11")
                            }
                        }
                    }
                },
                new Battle
                {
                    BattleName = "Second Blood",
                    BattleLog = new BattleLog
                    {
                        BattleLogName = "Second Blood Battlelog",
                        BattleEvents = new List<BattleEvent>()
                        {
                            new BattleEvent
                            {
                                Text = "Awfully bad formation",
                                Summary = "Bad formation",
                                DateTime = DateTime.Parse("279-04-13")
                            },
                            new BattleEvent
                            {
                                Text = "Better formation which makes sense",
                                Summary = "Good formation",
                                DateTime = DateTime.Parse("280-07-15")
                            }
                        }
                    }
                }
            };
            var context = new SamuraiContext();
            context.Battles.AddRange(battles);
            context.SaveChanges();
        }

        private static void AddOneSamurai()
        {
            var samurai = new Samurai { Name = "Anjin" };

            var context = new SamuraiContext();
            context.Samurais.Add(samurai);
            context.SaveChanges();
        }

        private static void AddSomeSamurais()
        {
            List<Samurai> samurais = new List<Samurai>()
            {
                new Samurai() {Name = "Shogun"},
                new Samurai() {Name = "Toranaga"},
                new Samurai() {Name = "Ishido"},
                new Samurai() {Name = "Wakisashi"}
            };

            var context = new SamuraiContext();
            context.Samurais.AddRange(samurais);
            context.SaveChanges();

        }
    }
}
