using System.Globalization;
using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/String Event Channel")]
    public class StringEventChannel : EventChannel<string>
    {
        public void RaiseEvent(bool value) => RaiseEvent(value.ToString());
        public void RaiseEvent(int value) => RaiseEvent(value.ToString());
        public void RaiseEvent(float value) => RaiseEvent(value.ToString(CultureInfo.CurrentCulture));
        public void RaiseEvent(double value) => RaiseEvent(value.ToString(CultureInfo.CurrentCulture));
    }
}
