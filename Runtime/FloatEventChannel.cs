using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/Float Event Channel")]
    public class FloatEventChannel : EventChannel<float>
    {
        public void RaiseEvent(int value) => base.RaiseEvent(value);
    }
}
