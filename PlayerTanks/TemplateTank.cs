using System.Drawing;
using TankWarsCopy.Game;
using TankWarsCopy.Game.Interfaces.ReadOnly;
using TankWarsCopy.Logic;
using TankWarsCopy.Logic.Interfaces;

namespace PlayerTanks
{
    public class TemplateTank : PlayerTank {
        public override Image Image { get; } = GetImage("<ImageName>");

        public override string Name { get; } = "<YourTankName>";

        public override ActionType TankAction(object obj, object me) {
            PlayerVariables variables = (PlayerVariables)obj;
            IReadOnlyTank self = (IReadOnlyTank)me;
            return ActionType.DoNothing;
        }
    }
}
