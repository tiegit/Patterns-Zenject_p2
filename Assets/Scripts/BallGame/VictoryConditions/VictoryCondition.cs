using System;
using System.Collections.Generic;

namespace BallGame
{
    public abstract class VictoryCondition : IDisposable
    {
        protected readonly IReadOnlyCollection<IBall> Balls;

        public event Action<bool> OnFinished;

        protected VictoryCondition(IReadOnlyCollection<IBall> balls)
        {
            Balls = balls;

            foreach (var ball in Balls)
            {
                ball.OnSelected += Interact;
            }
        }

        public abstract void Interact(ColorScriptableObject color);

        //public void Dispose() => DeactivateBalls();
        public void Dispose()
        {
            foreach (var ball in Balls)
            {
                ball.OnSelected -= Interact;
            }
        }

        protected void Finish(bool isSuccess)
        {
            OnFinished?.Invoke(isSuccess);

            DeactivateBalls();
        }

        private void DeactivateBalls()
        {
            foreach (var ball in Balls)
            {
                ball.OnSelected -= Interact;
                ball.Deactivate();
            }
        }
    }
}
