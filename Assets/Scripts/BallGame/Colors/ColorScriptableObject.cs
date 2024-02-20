using UnityEngine;

namespace BallGame
{
    [CreateAssetMenu(fileName = "Color", menuName = "ColorData/Color")]
    public class ColorScriptableObject : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private Color _color;

        public string Name => _name;
        public Color Color => _color;
    }
}
