using System;
using final_project_stable_release.Services;
using Raylib_cs;

namespace final_project_stable_release.Casting
{
    /// <summary>
    /// Class of the hero.
    /// </summary>
    public class Hero : Actor
    {
        private int _lastCollision;
        private int _lastDirection;
        private bool _canBounce = true;
        
        public Hero()
        {
            SetWidth(Constants.HERO_HEIGHT);
            SetHeight(Constants.HERO_WIDTH);
            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;

            Point _position = new Point(x,y);
            SetPosition(_position);
            SetVelocity(new Point(0,5));
            SetImage(Constants.IMAGE_HERO_LEFT);
        }
        
        public void BounceVertical()
        {
            if (_canBounce)
            {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();
                _lastCollision = GetY();
                SetVelocity(new Point(dx,-dy));
                
                _canBounce = false;
            }
            
        }

        public void DownwardDirection()
        {
            if (GetY()<= _lastCollision - 190)
            {
                SetVelocity(new Point(0,Constants.HERO_SPEED));
                _canBounce = true;
            }
        }

        public void NewImage(int vel)
        {
            _lastDirection = vel;
            if (_lastDirection > 0)
            {
                SetImage(Constants.IMAGE_HERO_RIGHT);
            }
            else if (_lastDirection < 0)
            {
                SetImage(Constants.IMAGE_HERO_LEFT);
            }
        }
    }
}