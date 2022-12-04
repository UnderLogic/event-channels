# Custom Events

While this library provides many of the common Unity types you will use, you may want to extend this library with your own custom events specific to your application.
Fortunately, this is rather easy and typically only involves creating a derived class from one of the base classes.
You may also add any additional helper properties and methods as you need.

## Channels

1. Create a new class that derives from [`EventChannel<T>`](channels/event-channel-generic.md), where `T` should be the type of event data.
2. Ensure the new type is marked with the `CreateAssetMenu` attribute, so you can create instances in the Editor.
3. Create any instances of the new event channel in your `Assets` folder.
4. Now you can use them throughout your application.

**NOTE:** If you want a custom [`VoidEventChannel`](channels/void-event-channel.md), derive from that class instead of the [`EventChannel`](channels/event-channel.md) base class. 
This will ensure you also get the custom editor for manually invoking the event.

## Listeners

1. Create a new class that derives from [`EventListener<T, TChannel>`](listeners/event-listener-generic.md) where `T` should be the underlying type and `TChannel` is the event channel type.
2. Now you can use the event listener in your components

**NOTE:** If you want a custom [`VoidEventListener`](listeners/void-event-listener.md), derive from that class instead of the [`EventListener<TChannel>`](listeners/event-listener.md) base class.
This will ensure you also get the custom editor for manually invoking the event.
