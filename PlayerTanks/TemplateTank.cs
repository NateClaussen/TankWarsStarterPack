using System.Drawing;
using TankWarsCopy.Game;
using TankWarsCopy.Game.Player;
using TankWarsCopy.Logic.Player;

namespace PlayerTanks
{
    public class TemplateTank : PlayerTank 
    {
        public override Image Image { get; } = GetImage("<ImageName>");

        public override string Name { get; } = "<YourTankName>";

        public override ActionType TankAction(PlayerVariables obj, Tank me) {
            return ActionType.DoNothing;
        }
    }
}
