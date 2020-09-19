using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature
    {

        public int Gold { set; get; }
        public int ExperiencePoints { set; get; }
        public int Level { set; get; }
    }
}
