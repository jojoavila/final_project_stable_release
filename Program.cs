using System;
using final_project_stable_release.Casting;
using final_project_stable_release.Scripting;
using final_project_stable_release.Services;
using System.Collections.Generic;

namespace final_project_stable_release
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Platform
            cast["platform"] = new List<Actor>();

            // Creating the 9 initial platforms
            Platform iniPlat1 = new Platform();
            iniPlat1.SetPosition(new Point(400,0));
            cast["platform"].Add(iniPlat1);

            Platform iniPlat2 = new Platform();
            iniPlat2.SetPosition(new Point(300,100));
            cast["platform"].Add(iniPlat2);
            
            Platform iniPlat3 = new Platform();
            iniPlat3.SetPosition(new Point(500,200));
            cast["platform"].Add(iniPlat3);

            Platform iniPlat4 = new Platform();
            iniPlat4.SetPosition(new Point(800,300));
            cast["platform"].Add(iniPlat4);

            Platform iniPlat5 = new Platform();
            iniPlat5.SetPosition(new Point(600,400));
            cast["platform"].Add(iniPlat5);

            Platform iniPlat6 = new Platform();
            iniPlat6.SetPosition(new Point(200,500));
            cast["platform"].Add(iniPlat6);

            Platform iniPlat7 = new Platform();
            iniPlat7.SetPosition(new Point(500,600));
            cast["platform"].Add(iniPlat7);

            Platform iniPlat8 = new Platform();
            iniPlat8.SetPosition(new Point(300,700));
            cast["platform"].Add(iniPlat8);

            Platform iniPlat9 = new Platform();
            iniPlat9.SetPosition(new Point(100,800));
            cast["platform"].Add(iniPlat9);

            
            // Ground (a little help when starting to play)
            cast["ground"] = new List<Actor>();

            cast["scoreBoard"]= new List<Actor>();
            ScoreBoard _scoreBoard = new ScoreBoard();
            cast["scoreBoard"].Add(_scoreBoard);

            Ground ground = new Ground();
            //cast["ground"].Add(ground);

            // The hero
            cast["hero"]= new List<Actor>();
            Hero hero = new Hero();
            cast["hero"].Add(hero);

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // Move the actors
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            // Handle collisions
            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            // Control the Hero
            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService, physicsService);
            script["input"].Add(controlActorsAction);

            // Create random platforms as old ones disappear from the screen
            CreatePlatforms createPlatforms = new CreatePlatforms();
            script["update"].Add(createPlatforms);

            // Delete actors that go under the screen
            HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction();
            script["update"].Add(handleOffScreenAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Doodle Jump", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}
