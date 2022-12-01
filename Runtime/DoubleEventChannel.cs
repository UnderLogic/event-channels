using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/Double Event Channel")]
    public class DoubleEventChannel : EventChannel<double>
    {
        public void RaiseEvent(int value) => RaiseEvent((double)value);
        public void RaiseEvent(float value) => RaiseEvent((double)value);
    }
}