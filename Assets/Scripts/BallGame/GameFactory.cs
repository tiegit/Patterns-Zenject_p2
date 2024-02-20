using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace BallGame
{
    public class GameFactory
    {
        private List<Ball> _balls;
        private List<ColorScriptableObject> _colors;

        public GameFactory(List<Ball> balls, List<ColorScriptableObject> colors)
        {
            _balls= balls;
            _colors = colors;
        }

        public VictoryCondition GetGame(int gameMode)
        {
            RepaintAndActivateBalls();

            switch (gameMode)
            {
                case 0:
                    return new VictoryByCount(_balls);

                case 1:
                    return new VictoryByColor(_balls);

                default:
                    throw new ArgumentException(nameof(gameMode));
            }
        }

        private void RepaintAndActivateBalls()
        {
            for (int i = 0; i < _balls.Count; i++)
            {
                _balls[i].Prepare(_colors[Random.Range(0, _colors.Count)]);
            }
        }
    }
}
