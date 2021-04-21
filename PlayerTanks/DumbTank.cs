using System;
using TankWarsCopy.Game;
using TankWarsCopy.Game.Player;
using TankWarsCopy.Logic.Player;

namespace PlayerTanks
{
    public class DumbTank : PlayerTank
    {
        public override string Name => "Dumb Tank";
        public override ActionType TankAction(PlayerVariables variables, Tank me) {          
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
