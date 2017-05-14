using UnityEngine;

namespace Assets.Scripts.Services
{
    public class PositionService : IPositionService
    {
        private const float AreaSize = 8.0f;
        private const float InitialYPosition = 2.0f;

        public Vector3 GetPosition()
        {
            var position2D = Random.insideUnitCircle * AreaSize;
            return new Vector3(position2D.x, InitialYPosition, position2D.y);
        }
    }
}
