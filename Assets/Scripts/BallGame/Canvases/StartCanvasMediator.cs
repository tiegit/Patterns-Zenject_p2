using Zenject;

namespace BallGame
{
    public class StartCanvasMediator
    {
        private StartCanvasView _startCanvas;
        private LevelLoadingData _levelLoadingData;
        private SceneLoadMediator _sceneLoaderMediator;

        [Inject]
        private void Construct(SceneLoadMediator sceneLoadMediator, StartCanvasView startCanvas, LevelLoadingData levelLoadingData)
        {
            _sceneLoaderMediator = sceneLoadMediator;
            _startCanvas = startCanvas;
            _levelLoadingData = levelLoadingData;
        }

        public void StartCountMode()
        {
            _levelLoadingData.Level = (int)SceneID.GameScene;
            _levelLoadingData.GameMode = (int)GameMode.ByCount;

            GoToScene();
        }

        public void StartColorMode()
        {
            _levelLoadingData.Level = (int)SceneID.GameScene;
            _levelLoadingData.GameMode = (int)GameMode.ByColor;

            GoToScene();
        }

        private void GoToScene()
        {
            _sceneLoaderMediator.GoToGameScene(_levelLoadingData);
            _startCanvas.Hide();
        }
    }
}
