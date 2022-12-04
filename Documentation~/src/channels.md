# Channels

## Overview

Event channels are implemented as `ScriptableObject` instances that can be raise events between components and across scenes.
They provide a `UnityAction` event when an event is raised.

Many of the event channels provide helper methods that make it easier to raise events from other components, including `UnityEvent` bindings.
This can be especially useful when using the [Listener](listeners.md) components.
