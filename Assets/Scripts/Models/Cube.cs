using Assets.Scripts.Services;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Models
{
    public class Cube : MonoBehaviour {
        private IPositionService _positionService;
        private const int PositionUpdateFrameInterval = 120;
	
        void Update () {
            //Reset cube position after specified interval has passed
            if (Time.frameCount % PositionUpdateFrameInterval == 0)
                transform.position = _positionService.GetPosition();
        }

        [Inject]
        public void Init(IPositionService positionService)
        {
            _positionService = positionService;
            transform.position = _positionService.GetPosition();
        }
    }
}
