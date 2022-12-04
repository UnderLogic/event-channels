namespace UnderLogic.Channels.Listeners
{
    public class DoubleEventListener : EventListener<double, DoubleEventChannel>
    {
        public void RaiseEvent(int value) => RaiseEvent((double)value);
        public void RaiseEvent(float value) => RaiseEvent((double)value);
    }
}
