using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/Vector3 Event Channel")]
    public class Vector3EventChannel : EventChannel<Vector3>
    {
        public void RaiseEvent(Vector2Int value) => base.RaiseEvent(new Vector3(value.x, value.y));
        public void RaiseEvent(Vector2 value) => base.RaiseEvent(new Vector3(value.x, value.y));
    }
}
