using Assets.Scripts.Services;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Models
{
    public class Sphere : MonoBehaviour {
        private IPositionService _positionService;
        private const int PositionUpdateFrameInterval = 540;
	
        void Update () {
            if (Time.frameCount % PositionUpdateFrameInterval != 0)
                return;

            //Reset sphere position after specified interval has passed
            transform.position = _positionService.GetPosition();

            //Stop rolling balls
            var rigidBody = GetComponent<Rigidbody>();
            rigidBody.velocity = Vector3.zero;
            rigidBody.angularVelocity = Vector3.zero;
        }

        [Inject]
        public void Init(IPositionService positionService)
        {
            _positionService = positionService;
            transform.position = _positionService.GetPosition();
        }
    }
}
