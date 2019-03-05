using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Battle
    {
        public int BattleId { get; set; }
        public BattleLog BattleLog { get; set; }
        public string BattleName { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
