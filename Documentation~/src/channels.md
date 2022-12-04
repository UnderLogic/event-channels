# Channels

## Overview

Runtime variables are implemented as `ScriptableObject` instances that can be used to share their data across components and scenes.
They also provide `UnityAction` events when their value changes or is about to be changed.

Many of the variables provide helper mutator methods that make it easier to manipulate their values from other components, including `UnityEvent` bindings.
This can be especially useful when using the [Watcher](watchers.md) components.
