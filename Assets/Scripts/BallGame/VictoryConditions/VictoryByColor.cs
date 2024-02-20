using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BallGame
{
    public class VictoryByColor : VictoryCondition
    {
        private readonly ColorScriptableObject _winColor;
        private int _count;

        public VictoryByColor(IReadOnlyCollection<IBall> balls) : base(balls)
        {
            _winColor = Balls.ElementAt(Random.Range(0, Balls.Count())).Color;

            _count = Balls.Count(ball => ball.Color == _winColor);

            Debug.Log($"Для победы нужно лопнуть все шары с цветом: {_winColor.Name}");
        }

        public override void Interact(ColorScriptableObject color)
        {
            if (color != _winColor)
            {
                Debug.Log("Лопнул шар не того цвета");
                Finish(false);
                return;
            }

            if (--_count != 0)
                return;
            
            Finish(true);
        }
    }
}
