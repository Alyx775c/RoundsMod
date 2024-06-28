using RoundsMenu.Classes;
using static RoundsMenu.Classes.Pages;

namespace RoundsMenu.Mods
{
    class Buttons
    {
        public static ButtonInfo[] button = [
            new (){
                anchorPoint = AnchorPoints.TopLeft,
                buttonText = "OP Mods",
                isTogglable = false,
                enabled = false,
                method = () => PageHandler.ChangePage(Page.OP),
                page = Page.Front,
                position = new(-175f, 119.25f),
                size = new(100, 25),
                fontSize = 22
            },

            new (){
                anchorPoint = AnchorPoints.MiddleTop,
                buttonText = "Toggle",
                isTogglable = true,
                enabled = false,
                method = () => OP.FastFire(button[2]),
                page = Page.OP,
                position = new(0f, 0f),
                size = new(100, 25),
                fontSize = 22
            }
        ];
    }
}
