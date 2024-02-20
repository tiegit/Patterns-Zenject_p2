using System;

namespace BallGame
{
    public class SceneLoader : ISimpleSceneLoader, ILevelLoader
    {
        private ZenjectSceneLoaderWrapper _zenjectSceneLoader;

        public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoader)
        {
            _zenjectSceneLoader = zenjectSceneLoader;
        }

        public void Load(LevelLoadingData levelLoadingData)
        {
            _zenjectSceneLoader.Load(container =>
            {
                container.BindInstance(levelLoadingData);
                // все что надо на следующей сцене биндить сюда!
            }, (int)levelLoadingData.Level);
        }

        public void Load(SceneID sceneID)
        {
            if (sceneID == SceneID.GameScene)
                throw new ArgumentException($"{SceneID.GameScene} cannot be startet without configuration, use IlevelLoader");

            _zenjectSceneLoader.Load(null, (int)sceneID);
        }
    }
}
