using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankWarsCopy.Game;
using TankWarsCopy.Game.Interfaces;
using TankWarsCopy.Game.Interfaces.ReadOnly;
using TankWarsCopy.Logic.Interfaces;

namespace PlayerTanks
{
    public class DumbTank : PlayerTank
    {
        public override string Name => "Dumb Tank";
        public override ActionType TankAction(object variables, object me) {            
            Random random = new Random();
            int rand = random.Next(0, 10);

            if (rand == 0) {
                return ActionType.MoveLeft;
            } else if (rand == 1) {
                return ActionType.MoveRight;
            } else if (rand == 2) {
                return ActionType.MoveUp;
            } else if (rand == 3) {
                return ActionType.MoveDown;
            } else if (rand == 4) {
                return ActionType.RotateRight;
            } else if (rand == 5) {
                return ActionType.RotateLeft;
            } else if (rand == 6) {
                return ActionType.Fire;
            } else if (rand == 7) {
                return ActionType.SetBomb;
            }
            return ActionType.DoNothing;

        }
    }
}
