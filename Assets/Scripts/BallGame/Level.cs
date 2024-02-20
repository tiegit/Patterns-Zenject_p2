using System;
using UnityEngine;

namespace BallGame
{
    public class Level
    {
        public event Action OnFinished;

        private VictoryCondition _victoryCondition;

        public void Start(VictoryCondition victoryCondition)
        {
            if (_victoryCondition != null)
            {
                _victoryCondition.OnFinished -= Finish; 
                _victoryCondition.Dispose();//
            }

            _victoryCondition = victoryCondition;
            _victoryCondition.OnFinished += Finish;
        }

        private void Finish(bool isSuccess)
        {
            OnFinished?.Invoke();
            Debug.Log(isSuccess ? "Победа!" : "Поражение…");
        }
    }
}
