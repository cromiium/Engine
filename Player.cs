using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player
    {
        public int CurrentHitPoints { set; get; }
        public int MaxHitPoints { set; get; }
        public int Gold { set; get; }
        public int ExperiencePoints { set; get; }
        public int Level { set; get; }
    }
}
