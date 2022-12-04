# Vector3EventListener

Derives from [`EventListener<T, TChannel>`](event-listener-generic.md).

## Description

Listens for events on a [`Vector3EventChannel`](../channels/vector3-event-channel.md) and invokes actions with a `Vector3` value when an event is raised.

## Public Methods

- `RaiseEvent(Vector2Int)` - Manually raises `onEventRaised` with the `Vector2Int` value provided.
- `RaiseEvent(Vector2)` - Manually raises `onEventRaised` with the `Vector2` value provided.

**NOTE:** Manually raising the event will only trigger the `UnityEvent` actions on **this** component.
It will **not** raise an event on the `Channel` itself.
