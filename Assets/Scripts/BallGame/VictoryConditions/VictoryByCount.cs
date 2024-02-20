using System.Collections.Generic;
using UnityEngine;

namespace BallGame
{
    public class VictoryByCount : VictoryCondition
    {
        private int _count;

        public VictoryByCount(IReadOnlyCollection<IBall> balls) : base(balls)
        {
            _count = Balls.Count;
            Debug.Log($"Для победы нужно лопнуть все {_count} шары.");
        }

        public override void Interact(ColorScriptableObject color)
        {
            if (--_count != 0)
                return;
            
            Finish(true);
        }
    }
}
