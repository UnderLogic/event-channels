using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/Double Event Channel")]
    public class DoubleEventChannel : EventChannel<double>
    {
        public void RaiseEvent(int value) => base.RaiseEvent(value);
        public void RaiseEvent(float value) => base.RaiseEvent(value);
    }
}
