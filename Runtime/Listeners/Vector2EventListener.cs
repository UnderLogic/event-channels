using UnityEngine;

namespace UnderLogic.Channels.Listeners
{
    public class Vector2EventListener : EventListener<Vector2, Vector2EventChannel>
    {
        public void RaiseEvent(Vector2Int value) => base.RaiseEvent(new Vector2(value.x, value.y));
    }
}
