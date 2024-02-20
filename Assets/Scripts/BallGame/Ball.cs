using System;
using UnityEngine;

namespace BallGame
{    
    public class Ball : MonoBehaviour, IBall
    {
        public event Action<ColorScriptableObject> OnSelected;

        private MeshRenderer _mesh;

        public ColorScriptableObject Color { get; private set; }

        private void Awake()
        {
            if (_mesh == null) _mesh = GetComponentInChildren<MeshRenderer>();
        }

        public void Prepare(ColorScriptableObject color)
        {
            Activate();

            Color = color;
            _mesh.material.color = Color.Color;
        }

        public void Select()
        {
            OnSelected?.Invoke(Color);
            Deactivate();
        }

        public void Deactivate() => gameObject.SetActive(false);

        private void Activate() => gameObject.SetActive(true);
    }
}
