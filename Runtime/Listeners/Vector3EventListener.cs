using UnityEngine;

namespace UnderLogic.Channels.Listeners
{
    public class Vector3EventListener : EventListener<Vector3, Vector3EventChannel>
    {
        public void RaiseEvent(Vector2Int value) => base.RaiseEvent(new Vector3(value.x, value.y));
        public void RaiseEvent(Vector2 value) => base.RaiseEvent(new Vector3(value.x, value.y));
    }
}
