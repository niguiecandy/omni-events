# Omni Events

## Description
This is an Event System that is implementing ['Observer Pattern'](https://en.wikipedia.org/wiki/Observer_pattern) using `ScriptableObject`.

> Ref : [3 cool ways to architect your game with Scriptable Objects](https://unity3d.com/kr/how-to/architect-with-Scriptable-Objects?utm_campaign=saas_global_nurture_2018-Paid-subs-CLC-Monthly&utm_content=2018-CLC-Monthly-programmer-architect-with-Scriptable-Objects-v2&utm_medium=email&utm_source=Eloqua)

You can create an event 'asset' in the project folder, and reference it from any GameObjects in any Scenes. This is especially useful if you want to connect UIs and GameObject instances throughout the scenes.

This pattern has the following advantages :
1. **Modular**  No direct references are needed between GameObject instances. This makes GameObjects easy to be saved as prefabs.
2. **Editable** Change in one script doesn't affect others.
3. **Debuggable** Modulized scripts are easy to be debugged.

This is a **Plus**

**Designer-friendly** : Exposed in the inspector and no scripting is needed.

## Import
This repo can be imported to your project as a submodule. In Unity, This will be treated as a custom package.
1. Add this repo as a submodule of your project. Clone at `YourProject/Packages/Omni-Events`.
2. Open `YourProject/Packages/manifest.json` file, and add **"com.ngc6543.omnievents"** at the end of the "dependencies".
	```json
	"dependencies": {
		...
		"com.ngc6543.omnievents": "0.1.0"
	}
	```

## Usage
1. OmniEvent Assets
	- Right-click on the Project panel, and Select 'Omni Events/...' to create an event asset.
	- Various types of parameters are supported.
2. OmniEventListener Components
	- Add an OmniEventListener component of matching parameter to a GameObject, and assign event asset(s).
	- Add any public method or property of the same parameter to `Invoked` UnityEvent.
3. OmniEventInvoker Components
	- Inspector helper components for debugging / easy invoking.