using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/Vector4 Event Channel")]
    public class Vector4EventChannel : EventChannel<Vector4>
    {
        public void RaiseEvent(Vector2Int value) => base.RaiseEvent(new Vector4(value.x, value.y));
        public void RaiseEvent(Vector2 value) => base.RaiseEvent(new Vector4(value.x, value.y));
        public void RaiseEvent(Vector3 value) => base.RaiseEvent(new Vector4(value.x, value.y, value.z));
    }
}
