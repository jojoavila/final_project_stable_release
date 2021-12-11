
namespace final_project_stable_release.Casting
{
    public class Ground : Actor
    {
        /// <summary>
        /// Class of a ground.
        /// </summary>
        public Ground()
        {
            SetWidth(Constants.MAX_X);
            SetHeight(24);

            int x = 0;
            int y = 700;

            Point _position = new Point(x,y);
            SetPosition(_position);
            
            _velocity = new Point(0,1);
        }
    }
}