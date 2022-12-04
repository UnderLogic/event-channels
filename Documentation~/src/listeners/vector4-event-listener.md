# Vector4EventListener

Derives from [`EventListener<T, TChannel>`](event-listener-generic.md).

## Description

Listens for events on a [`Vector4EventChannel`](../channels/vector4-event-channel.md) and invokes actions with a `Vector4` value when an event is raised.

## Public Methods

- `RaiseEvent(Vector2Int)` - Manually raises `onEventRaised` with the `Vector2Int` value provided.
- `RaiseEvent(Vector2)` - Manually raises `onEventRaised` with the `Vector2` value provided.
- `RaiseEvent(Vector3)` - Manually raises `onEventRaised` with the `Vector3` value provided.

**NOTE:** Manually raising the event will only trigger the `UnityEvent` actions on **this** component.
It will **not** raise an event on the `Channel` itself.
