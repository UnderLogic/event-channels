# StringEventListener

Derives from [`EventListener<T, TChannel>`](event-listener-generic.md).

## Description

Listens for events on a [`StringEventChannel`](../channels/string-event-channel.md) and invokes actions with a `string` value when an event is raised.

## Public Methods

- `RaiseEvent(bool)` - Manually raises `onEventRaised` with the string representation of the `bool` value provided.
- `RaiseEvent(int)` - Manually raises `onEventRaised` with the string representation of the signed `int` value provided.
- `RaiseEvent(float)` - Manually raises `onEventRaised` with the string representation of the `float` value provided.
- `RaiseEvent(double)` - Manually raises `onEventRaised` with the string representation of the `double` value provided.

**NOTE:** Manually raising the event will only trigger the `UnityEvent` actions on **this** component.
It will **not** raise an event on the `Channel` itself.

**NOTE:** The `RaiseEvent()` methods will format the string using the `CultureInfo.CurrentCulture`.
