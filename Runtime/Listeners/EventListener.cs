using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Channels.Listeners
{
    public abstract class EventListener<TChannel> : MonoBehaviour where TChannel : EventChannel
    {
        [SerializeField] private TChannel channel;

        [Space]
        public UnityEvent onEventRaised;

        public TChannel Channel => channel;

        private void OnEnable()
        {
            if (channel != null)
                channel.EventRaised += RaiseEvent;
        }

        private void OnDisable()
        {
            if (channel != null)
                channel.EventRaised -= RaiseEvent;
        }

        public void RaiseEvent() => onEventRaised?.Invoke();
    }

    public abstract class EventListener<T, TChannel> : MonoBehaviour where TChannel : EventChannel<T>
    {
        [SerializeField] private TChannel channel;

        [Space]
        public UnityEvent<T> onEventRaised;
        
        public TChannel Channel => channel;

        private void OnEnable()
        {
            if (channel != null)
                channel.EventRaised += RaiseEvent;
        }

        private void OnDisable()
        {
            if (channel != null)
                channel.EventRaised -= RaiseEvent;
        }

        public void RaiseEvent(T value) => onEventRaised?.Invoke(value);
    }
}
