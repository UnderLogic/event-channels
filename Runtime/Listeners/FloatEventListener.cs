namespace UnderLogic.Channels.Listeners
{
    public class FloatEventListener : EventListener<float, FloatEventChannel>
    {
        public void RaiseEvent(int value) => RaiseEvent((float)value);
    }
}