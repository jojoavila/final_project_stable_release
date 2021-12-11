using System;

namespace final_project_stable_release
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 900;
        public const int MAX_Y = 900;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_PLATFORM = "./Assets/Platform.png";
        public const string IMAGE_HERO_RIGHT = "./Assets/Doodle-Right.png";
        public const string IMAGE_HERO_LEFT = "./Assets/Doodle-Left.png";
        public const string IMAGE_GROUND = "./Assets/ball.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        //public const int BALL_X = MAX_X / 2;
        //public const int BALL_Y = MAX_Y - 125;

        //public const int BALL_DX = 8;
        //public const int BALL_DY = BALL_DX * -1;

        //public const int PADDLE_X = MAX_X / 2;
        //public const int PADDLE_Y = MAX_Y - 25;

        public const int PLATFORM_WIDTH = 100;
        public const int PLATFORM_HEIGHT = 35;

        public const int PLATFOM_SPEED = 3;

        public const int HERO_SPEED = 6;

        public const int HERO_WIDTH = 40;
        public const int HERO_HEIGHT = 40;

        public const int GROUND_WIDTH = MAX_X;
        public const int GROUND_HEIGHT = 24;
        public const int ON_SCREEN_PLATFORM_LIMIT = 9;
    }

}