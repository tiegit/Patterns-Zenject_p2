using Zenject;

namespace BallGame
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindLoadData();

            BindLoader();
        }

        private void BindLoadData() => Container.Bind<LevelLoadingData>().AsSingle().NonLazy();

        private void BindLoader()
        {
            Container.Bind<ZenjectSceneLoaderWrapper>().AsSingle();
            Container.BindInterfacesAndSelfTo<SceneLoader>().AsSingle();
            Container.Bind<SceneLoadMediator>().AsSingle().NonLazy();
        }
    }
}
