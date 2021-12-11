using System;
using System.Collections.Generic;
using final_project_stable_release.Casting;

namespace final_project_stable_release
{
    public abstract class Action
    {
        public abstract void Execute(Dictionary<string, List<Actor>> cast);
    }
}