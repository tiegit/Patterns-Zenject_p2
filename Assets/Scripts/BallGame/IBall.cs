using System;

namespace BallGame
{
    public interface IBall
    {
        ColorScriptableObject Color { get; }

        event Action<ColorScriptableObject> OnSelected;

        public void Deactivate();
    }
}
