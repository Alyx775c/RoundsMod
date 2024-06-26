using RoundsMod.Classes;

namespace RoundsMod.Mods
{
    class Buttons
    {
        public static ButtonInfo[][] button =
        [
            [ // Main
                new() {buttonText="Fire Faster", method = () => OP.FastFireOn(), disableMethod = () => OP.FastFireOff(), isTogglable=true }
            ],
            // other stuff
        ];
    }
}
