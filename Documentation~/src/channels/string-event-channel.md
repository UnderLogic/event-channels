# StringEventChannel

Derives from [`EventChannel<T>`](event-channel-generic.md).

## Description

Represents an event channel that can raise events containing a `string` value.

## Public Methods

- `RaiseEvent(bool)` - Raises an event on the channel with the string representation of the `bool` value provided.
- `RaiseEvent(int)` - Raises an event on the channel with the string representation of the signed `int` value provided.
- `RaiseEvent(float)` - Raises an event on the channel with the string representation of the `float` value provided.
- `RaiseEvent(double)` - Raises an event on the channel with the string representation of the `double` value provided.

**NOTE:** The `RaiseEvent()` methods will format the string using the `CultureInfo.CurrentCulture`.
