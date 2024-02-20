using UnityEngine;
using Zenject;

namespace BallGame
{
    public class GameSceneInstaller : MonoInstaller
    {
        [SerializeField] GameBootstrap _gameBootstrap;
        [SerializeField] private FinalCanvasView _finalCanvas;

        public override void InstallBindings()
        {
            BindBootstraper();
            BindBallsSpawner();
            BindCanvas();
            BindCanvasMediator();
        }

        private void BindBootstraper() => Container.Bind<GameBootstrap>().FromInstance(_gameBootstrap).AsSingle().NonLazy();
        
        private void BindBallsSpawner() => Container.Bind<BallsSpawner>().AsSingle();
        
        private void BindCanvas() => Container.Bind<FinalCanvasView>().FromInstance(_finalCanvas).AsSingle();

        private void BindCanvasMediator() => Container.Bind<FinalCanvasMediator>().AsSingle().NonLazy();
    }
}
