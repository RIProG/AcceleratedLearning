using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class BattleLog
    {
        public int BattleLogId { get; set; }
        public int BattleId { get; set; }
        public Battle Battle { get; set; }
        public string BattleLogName { get; set; }
        public List<BattleEvent> BattleEvents { get; set; }
    }
}
