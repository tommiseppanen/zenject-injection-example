using Assets.Scripts.Models;
using UnityEngine;
using Zenject;

namespace Assets.Scripts
{
    public class AddCubeButton : MonoBehaviour {
        private IFactory<Cube> _cubeFactory; 

        [Inject]
        public void Init(CubeFactory cubeFactory)
        {
            _cubeFactory = cubeFactory;
        }

        public void AddGameObject()
        {
            _cubeFactory.Create();
        }
    }
}
