using System.Globalization;
using UnityEngine;

namespace UnderLogic.Channels
{
    [CreateAssetMenu(menuName = "Channels/String Event Channel")]
    public class StringEventChannel : EventChannel<string>
    {
        public void RaiseEvent(bool value) => base.RaiseEvent(value.ToString());
        public void RaiseEvent(int value) => base.RaiseEvent(value.ToString());
        public void RaiseEvent(float value) => base.RaiseEvent(value.ToString(CultureInfo.CurrentCulture));
        public void RaiseEvent(double value) => base.RaiseEvent(value.ToString(CultureInfo.CurrentCulture));
    }
}
