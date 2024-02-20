using System.Collections.Generic;
using UnityEngine;

namespace BallGame
{
    internal class BallsSpawner
    {
        private List<Ball> _balls = new List<Ball>();

        public List<Ball> SpawnBalls(Ball _ballPrefab, int ballCount)
        {
            for (int i = 0; i < ballCount; i++)
            {
                Vector3 position = new Vector3(i, 0, 0);

                var ballGO = GameObject.Instantiate(_ballPrefab, Vector3.zero + position, Quaternion.identity);

                Ball ball = ballGO.GetComponent<Ball>();

                _balls.Add(ball);

                ball.Deactivate();
            }

            return _balls;
        }
    }
}