# EventListener\<TChannel>

Abstract base class that all other non-data event channel listeners derive from.

## Description

Listens for events on a non-data event channel `TChannel` and invokes actions when an event is raised.

## Serialized Fields (Inspector)

- `channel : TChannel` - The channel to listen on for events.
- `onEventRaised : UnityEvent` - The actions to perform when an event is raised on the channel.

## Public Properties

- `Channel : TChannel` **(get)** - The channel being listened on for events.

## Public Methods

- `RaiseEvent()` - Manually raises `onEventRaised` on the component.

**NOTE:** Manually raising the event will only trigger the `UnityEvent` actions on **this** component.
It will **not** raise an event on the `Channel` itself.
