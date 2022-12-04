using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Channels
{
    public abstract class EventChannel : ScriptableObject
    {
        public event UnityAction EventRaised;

        public void RaiseEvent() => EventRaised?.Invoke();
    }

    public abstract class EventChannel<T> : ScriptableObject
    {
        public event UnityAction<T> EventRaised;

        public void RaiseEvent(T value) => EventRaised?.Invoke(value);
    }
}
