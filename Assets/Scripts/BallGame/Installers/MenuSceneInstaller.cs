using UnityEngine;
using Zenject;

namespace BallGame
{
    public class MenuSceneInstaller : MonoInstaller
    {
        [SerializeField] private StartCanvasView _startCanvas;

        public override void InstallBindings()
        {
            BindCanvas();
            BindCanvasMediator();
        }

        private void BindCanvas() =>Container.Bind<StartCanvasView>().FromInstance(_startCanvas).AsSingle();

        private void BindCanvasMediator() =>  Container.Bind<StartCanvasMediator>().AsSingle().NonLazy();
    }
}
