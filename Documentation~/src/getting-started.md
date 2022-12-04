# Getting Started

## Context

To best understand the purpose of this library and the problems it solves,
it is highly recommended to watch the [Unite 2017: Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk)
by Ryan Hipple.

## Use Cases

### Event Bus

The common case of needing to notify various components of events within an application, potentially across multiple scenes.
Includes the ability to chain events to cascade logic and triggers in sequence.
Easy to drag and drop references in the Editor and view/modify them in the Inspector during play mode.

### Decoupling

The common case of having multiple observers of a single event being able to react independently of each other.
For example, playing a sound while also showing a game over screen when the player dies.
This helps enforce the single responsibility principle as well as reduce tight coupling between types.

### Event-Based Architecture

The case of only wanting to update or perform actions when necessary (reactively) instead of wastefully computing each frame.
This is very common in UI-heavy applications.

See `runtime-variables` library in the [related-libraries](related-libraries.md) section for working with observable variables
and `runtime-collections` library in the [related-libraries](related-libraries.md) section for working with observable collections.

## Samples

The `Samples~` folder contains sample scenes showcasing various aspects of the library in action.
It is recommended to import and play around with them in Unity to get a feel for how to use the library.
