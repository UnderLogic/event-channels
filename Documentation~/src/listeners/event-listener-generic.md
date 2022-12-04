# EventListener\<T, TChannel>

Abstract base class that all other data event channel listeners derive from.

## Description

Listens for events on a event channel `TChannel` and invokes actions with `T` when an event is raised.

## Serialized Fields (Inspector)

- `channel : TChannel` - The channel to listen on for events.
- `onEventRaised : UnityEvent<T>` - The actions to perform when an event is raised on the channel.

## Public Properties

- `Channel : TChannel` **(get)** - The channel being listened on for events.

## Public Methods

- `RaiseEvent(T)` - Manually raises `onEventRaised` on the component with the value `T` provided.

**NOTE:** Manually raising the event will only trigger the `UnityEvent` actions on **this** component.
It will **not** raise an event on the `Channel` itself.
