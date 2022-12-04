# FloatEventListener

Derives from [`EventListener<T, TChannel>`](event-listener-generic.md).

## Description

Listens for events on a [`FloatEventChannel`](../channels/float-event-channel.md) and invokes actions with a `float` value when an event is raised.

## Public Methods

- `RaiseEvent(int)` - Manually raises `onEventRaised` with the signed `int` value provided.

**NOTE:** Manually raising the event will only trigger the `UnityEvent` actions on **this** component.
It will **not** raise an event on the `Channel` itself.