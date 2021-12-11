using System;
using System.Collections.Generic;
using final_project_stable_release.Casting;
using final_project_stable_release.Scripting;

namespace final_project_stable_release.Scripting
{
    /// <summary>
    /// An action, to erase the actors that go under the bottom of the window.
    /// </summary>
    public class HandleOffScreenAction : Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> platformList = cast["platform"];
            List<Actor> platformToRemove = new List<Actor>();
            foreach (Actor actor in platformList)
            {
                Platform plat = (Platform)actor;
                int x = plat.GetX();
                int y = plat.GetY();
                if (y >= Constants.MAX_Y)
                {
                    // _audioService.PlaySound(Constants.SOUND_OVER);
                    platformToRemove.Add(plat);
                }
                               
            }
            foreach (Platform plat in platformToRemove)
            {
                platformList.Remove(plat);
            }

            // List<Actor> groundList = cast["ground"];
            // List<Actor> groundToRemove = new List<Actor>();
            // foreach (Actor actor in groundList)
            // {
            //     Ground ground = (Ground)actor;
            //     int x = ground.GetX();
            //     int y = ground.GetY();
            //     if (y >= Constants.MAX_Y)
            //     {
            //         // _audioService.PlaySound(Constants.SOUND_OVER);
            //         platformToRemove.Add(ground);
            //     }
                               
            // }
            // foreach (Ground ground in groundToRemove)
            // {
            //     groundList.Remove(ground);
            // }

            List<Actor> heroList = cast["hero"];
            List<Actor> heroToRemove = new List<Actor>();
            foreach (Actor actor in heroList)
            {
                Hero hero = (Hero)actor;
                int x = hero.GetX();
                int y = hero.GetY();
                if (y >= Constants.MAX_Y + 100)
                {
                    // _audioService.PlaySound(Constants.SOUND_OVER);
                    heroToRemove.Add(hero);
                }
                               
            }
            foreach (Hero hero in heroToRemove)
            {
                heroList.Remove(hero);
            }

            foreach (Actor actor in heroList)
            {
                Hero hero = (Hero)actor;
                int x = hero.GetX();
                int y = hero.GetY();
                if (x >= Constants.MAX_X)
                {
                    hero.SetPosition(new Point(0,y));
                }
                if (x <= 0)
                {
                    hero.SetPosition(new Point(Constants.MAX_X,y));
                }
            }    

        }
    }
}