using System.Globalization;

namespace UnderLogic.Channels.Listeners
{
    public class StringEventListener : EventListener<string, StringEventChannel>
    {
        public void RaiseEvent(bool value) => RaiseEvent(value.ToString());
        public void RaiseEvent(int value) => RaiseEvent(value.ToString());
        public void RaiseEvent(float value) => RaiseEvent(value.ToString(CultureInfo.CurrentCulture));
        public void RaiseEvent(double value) => RaiseEvent(value.ToString(CultureInfo.CurrentCulture));
    }
}