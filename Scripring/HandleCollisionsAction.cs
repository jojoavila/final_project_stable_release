using System.Collections.Generic;
using final_project_stable_release.Casting;
using final_project_stable_release.Services;

namespace final_project_stable_release.Scripting
{
    /// <summary>
    /// An action, so the hero bounces or jump when collides with a platform.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        } 

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> heroList = cast["hero"];
            List<Actor> platformList = cast["platform"];
            Actor scoreBoard = cast["scoreBoard"][0];

            foreach (Actor actor in heroList)
            {
                ScoreBoard _scoreBoard = (ScoreBoard)scoreBoard;
                Hero hero = (Hero)actor;
                int x = hero.GetX();
                int y = hero.GetY();
                               
            
                foreach (Actor platform in platformList)
                {
                                     
                    if (_physicsService.IsCollision(platform, hero))
                    {
                        hero.BounceVertical();
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        _scoreBoard.AddPoints(5);

                    }
                    hero.DownwardDirection();             
                }
            }
        }
    }
}