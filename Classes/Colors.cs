using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RoundsMenu.Classes
{
    class Colors
    {
        public static Color DarkGray { get; } = new(15, 15, 15);
        public static Color DarkBlue { get; } = new(6, 47, 59);

        public static Color colorToUnity(Color color)
        {
            return new(color.r / 255, color.g / 255, color.b / 255);
        }
    }
}
