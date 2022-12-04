# Listeners

Event listeners are implemented as `MonoBehaviour` components that can be used to bind `UnityEvent` actions to events via the Unity Inspector.
This allows listeners to notify other components without needing to write extra boilerplate code for subscribing and unsubscribing to those event channels.

It also allows multiple actions to be triggered from a single event easily.
