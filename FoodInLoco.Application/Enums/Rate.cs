using System.ComponentModel;

namespace FoodInLoco.Application.Enums
{
    [Flags]
    public enum Rate
    {
        [Description("Péssimo")]
        One = 1,
        [Description("Ruim")]
        Two = 2,
        [Description("Regular")]
        Three = 3,
        [Description("Bom")]
        Four = 4,
        [Description("Excelente")]
        Five = 5
    }
}
