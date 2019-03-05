using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class BattleEvent
    {
        public int BattleEventId { get; set; }
        public int BattleLogId { get; set; }
        public BattleLog BattleLog { get; set; }
        public string Text { get; set; }
        public string Summary { get; set; }
        public DateTime DateTime { get; set; }
    }
}
