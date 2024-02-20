using Zenject;

namespace MediatorSceneScripts
{
    public class MediatorsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindPlayerInputMediator();
            BindViewPanelsMediator();
        }

        private void BindPlayerInputMediator() => Container.Bind<PlayerInputMediator>().AsSingle();

        private void BindViewPanelsMediator() => Container.Bind<ViewPanelsMediator>().AsSingle();
    }
}
