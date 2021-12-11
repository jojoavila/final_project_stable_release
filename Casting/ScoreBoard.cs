namespace final_project_stable_release.Casting
{
    public class ScoreBoard : Actor
    {
        private int _score = 0;
        //private bool _canAdd = true;
        //private int _lastCollision;
        public ScoreBoard()
        {
            _position = new Point(10, 10);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }
        /// <summary>
        /// Increments the points by the amount specified and updates the
        /// text.
        /// </summary>
        /// <param name="points"></param>
        public void AddPoints(int points)
        {
            _score += points;
            UpdateText();

        }

        /// <summary>
        /// Removes points worth half the amount of characters in a word.
        /// </summary>
        public void RemovePoints(int points)
        {
            _score -= points / 2;
            UpdateText();
        }

        /// <summary>
        /// Updates the text to reflect the new points amount.
        /// This should be called whenever the points are updated.
        /// </summary>
        private void UpdateText()
        {
            _text = $"Score: {_score}";
        }

        public int GetPoints()
        {
            return _score;
        }
    }
}