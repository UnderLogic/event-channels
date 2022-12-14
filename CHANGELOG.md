# Changelog
All notable changes to this library will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.4.2] - 2022-12-28

### Added

- `ScriptableObjectEventChannel` variant
- `ScriptableObjectEventListener` component
- Icons for event channels in the Editor
- Icons for event listeners in the Editor

## [0.4.1] - 2022-12-08

### Fixed

- Missing meta files

## [0.4.0] - 2022-12-04

### Added

- `ColorEventChannel` variant
- `ColorEventListener` component
- `Vector2IntEventChannel` variant
- `Vector2IntEventListener` component
- `Vector2EventChannel` variant
- `Vector2EventListener` component
- `Vector3EventChannel` variant
- `Vector3EventListener` component
- `Vector4EventChannel` variant
- `Vector4EventListener` component

## [0.3.1] - 2022-12-04

### Added

- Docs via `mdbook` in `Documentation~` directory
- GitHub CI/CD workflows for documentation

### Changed

- Exposed `Channel` getter property on `EventListener` component

## [0.3.0] - 2022-12-01

### Added

- `EventChannelEditor` - custom editor
- `EventListenerEditor<TChannel>` - abstract base class
- `VoidEventListenerEditor` - custom editor
- `RaiseEvent(int)` method for `DoubleEventChannel`
- `RaiseEvent(float)` method for `DoubleEventChannel`
- `RaiseEvent(int)` method for `FloatEventChannel`
- `RaiseEvent(bool)` method for `StringEventChannel`
- `RaiseEvent(int)` method for `StringEventChannel`
- `RaiseEvent(float)` method for `StringEventChannel`
- `RaiseEvent(double)` method for `StringEventChannel`
- `RaiseEvent(int)` method for `DoubleEventListener`
- `RaiseEvent(float)` method for `DoubleEventListener`
- `RaiseEvent(int)` method for `FloatEventListener`
- `RaiseEvent(bool)` method for `StringEventListener`
- `RaiseEvent(int)` method for `StringEventListener`
- `RaiseEvent(float)` method for `StringEventListener`
- `RaiseEvent(double)` method for `StringEventListener`

### Fixed

- Small fixes in Listeners sample scene

## [0.2.0] - 2022-12-01

### Added

- `EventListener<TChannel>` abstract base class
- `EventListener<T, TChannel>` abstract base class
- `BoolEventListener` component
- `DoubleEventListener` component
- `FloatEventListener` component
- `IntEventListener` component
- `StringEventListener` component
- `TransformEventListener` component
- `VoidEventListener` component
- Listeners sample scene

### Fixed

- Root namespace should now be `UnderLogic.Channels`

## [0.1.0] - 2022-12-01

### Added

- `EventChannel` abstract base class
- `EventChannel<T>` abstract base class
- `BoolEventChannel` variant
- `DoubleEventChannel` variant
- `FloatEventChannel` variant
- `IntEventChannel` variant
- `StringEventChannel` variant
- `TransformEventChannel` variant
- `VoidEventChannel` variant
- Channels sample scene
