using Assets.Scripts.Models;
using Assets.Scripts.Services;
using UnityEngine;
using Zenject;

namespace Assets.Scripts
{
    public class Installer : MonoInstaller<Installer>
    {
        [SerializeField]
        private Transform cube;
        public override void InstallBindings()
        {
            Container.Bind<IPositionService>().To<PositionService>().AsSingle();
            Container.BindFactory<Cube, CubeFactory>().FromComponentInNewPrefab(cube);
        }
    }
}