namespace pcs.Core
{
    class Splashes
    {
        public static string GenCrashSplash()
        {
            switch (PCS.Rand.Next(7))
            {
                case 0:
                    return "We're sorry :(.";
                case 1:
                    return "Crash?";
                case 2:
                    return "Crash!";
                case 3:
                    return "My bad..";
                case 4:
                    return "Developer! Developer! Are you here?";
                case 5:
                    return "Bugs! They're everywhere!";
                case 6:
                    return "Crashes! Om-nom-nom...";
                default:
                    return ".";
            }
        }
    }
}
