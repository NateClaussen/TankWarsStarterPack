using System.Drawing;
using TankWarsCopy.Game;
using TankWarsCopy.Game.Player;
using TankWarsCopy.Logic.Player;

namespace PlayerTanks
{
    public class DoNothingTank : PlayerTank
    {
        public override Image Image { get; } = GetImage("Tank4.jpg");
        public override string Name => "Do Nothing Tank";

        public override ActionType TankAction(PlayerVariables variables, Tank me) {
            return ActionType.DoNothing;
        }
    }
}
