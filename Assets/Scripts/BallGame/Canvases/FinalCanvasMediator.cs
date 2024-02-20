using System;
using Zenject;

namespace BallGame
{
    public class FinalCanvasMediator : IDisposable
    {
        private FinalCanvasView _finalCanvas;
        private GameBootstrap _gameBootstrap;

        private SceneLoadMediator _sceneLoaderMediator;

        [Inject]
        private void Construct(SceneLoadMediator sceneLoadMediator, FinalCanvasView finalCanvas)
        {
            _sceneLoaderMediator = sceneLoadMediator;
            _finalCanvas = finalCanvas;
        }

        public void Initialize(GameBootstrap gameBootstrap) 
        { 
            _gameBootstrap = gameBootstrap;            
            _gameBootstrap.Level.OnFinished += OnlevelFinished;
        }

        public void ExitToMenu() => _sceneLoaderMediator.GoToMenuScene();

        public void ResetCurrentMode()
        {
            _finalCanvas.Hide();
            _gameBootstrap.ResetCurrentMode();
        }

        public void LevelStarted() => _finalCanvas.Hide();

        private void OnlevelFinished() => _finalCanvas.Show();

        public void Dispose() => _gameBootstrap.Level.OnFinished -= OnlevelFinished;        
    }
}
