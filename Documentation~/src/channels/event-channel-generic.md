# EventChannel\<T>

Abstract base class that all other data event channels derive from.

## Description

Represents an event channel that can raise events containing a value `T`.

## Public Events

- `EventRaised : UnityAction<T>` - Invoked when an event is raised on the channel.

## Public Methods

- `RaiseEvent(T)` - Raises an event on the channel with the value `T` provided.
