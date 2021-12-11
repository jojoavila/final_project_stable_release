using System;

namespace final_project_stable_release.Casting
{
    /// <summary>
    /// Class of platforms.
    /// </summary>
    public class Platform : Actor
    {
        Random randNum = new Random();
        public Platform()
        {
            SetWidth(Constants.PLATFORM_WIDTH);
            SetHeight(Constants.PLATFORM_HEIGHT);
            SetImage(Constants.IMAGE_PLATFORM);
            
            int x = randNum.Next(25, Constants.MAX_X - (Constants.PLATFORM_WIDTH + 10));
            int y = 0;
            
            
            _position = new Point(x, y);
            _velocity = new Point(0, Constants.PLATFOM_SPEED);          
        }
    }
}