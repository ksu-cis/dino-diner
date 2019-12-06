/*  Size.cs
*   Author: Creighton Glasscock
*/
namespace DinoDiner.Menu
{
    //Size enum for drinks, sides, and other menu items.
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public static class SizeExtension
    {
        /// <summary>
        /// Converts size enum to string
        /// </summary>
        /// <returns>Size enum</returns>
        public static string SizeString(Size s)
        {
            switch (s)
            {
                case Size.Small: return "Small";
                case Size.Medium: return "Medium";
                case Size.Large: return "Large";
                default: return "Unknown Size";
            }
        }
    }

}
