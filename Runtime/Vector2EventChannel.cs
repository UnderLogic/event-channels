using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/Vector2 Event Channel")]
    public class Vector2EventChannel : EventChannel<Vector2>
    {
        public void RaiseEvent(Vector2Int value) => base.RaiseEvent(new Vector2(value.x, value.y));
    }
}
