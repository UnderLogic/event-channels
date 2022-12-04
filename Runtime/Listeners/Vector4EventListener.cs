using UnityEngine;

namespace UnderLogic.Channels.Listeners
{
    public class Vector4EventListener : EventListener<Vector4, Vector4EventChannel>
    {
        public void RaiseEvent(Vector2Int value) => base.RaiseEvent(new Vector4(value.x, value.y));
        public void RaiseEvent(Vector2 value) => base.RaiseEvent(new Vector4(value.x, value.y));
        public void RaiseEvent(Vector3 value) => base.RaiseEvent(new Vector4(value.x, value.y, value.z));
    }
}
