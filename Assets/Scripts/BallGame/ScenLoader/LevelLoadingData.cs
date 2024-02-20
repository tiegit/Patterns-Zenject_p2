using System;

namespace BallGame
{
    public class LevelLoadingData
    {
        private int _level;
        private int _gameMode;
        
        public int Level
        {
            get => _level;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));

                _level = value;
            }
        }

        public int GameMode
        {
            get => _gameMode;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));

                _gameMode = value;
            }
        }
    }
}
