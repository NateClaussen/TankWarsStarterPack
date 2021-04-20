using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankWarsCopy.Game;
using TankWarsCopy.Game.Interfaces;
using TankWarsCopy.Game.Interfaces.ReadOnly;
using TankWarsCopy.Logic.Interfaces;

namespace PlayerTanks
{
    public class DoNothingTank : PlayerTank
    {
        public override Image Image { get; } = GetImage("Tank4.jpg");
        public override string Name => "Do Nothing Tank";
        private int count = 0;


        public override ActionType TankAction(object variables, object me) {
            return ActionType.DoNothing;
        }
    }
}
