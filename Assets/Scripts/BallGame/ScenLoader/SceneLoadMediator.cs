using Zenject;

namespace BallGame
{
    public class SceneLoadMediator
    {
        private ISimpleSceneLoader _simpleSceneLoader;
        private ILevelLoader _levelLoader;

        [Inject]
        private void Constract(ISimpleSceneLoader simpleSceneLoader, ILevelLoader levelLoader)
        {
            _simpleSceneLoader = simpleSceneLoader;
            _levelLoader = levelLoader;
        }

        public void GoToGameScene(LevelLoadingData levelLoadingData)
            => _levelLoader.Load(levelLoadingData);

        public void GoToMenuScene()
            => _simpleSceneLoader.Load(SceneID.MenuScene);
    }
}
