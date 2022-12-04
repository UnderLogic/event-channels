# EventChannel

Abstract base class that all other non-data event channels derive from.

## Description

Represents an event channel that can raise events which do not contain any associated data.

## Public Events

- `EventRaised : UnityAction` - Invoked when an event is raised on the channel.

## Public Methods

- `RaiseEvent()` - Raises an event on the channel.
