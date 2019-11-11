# Omni Events

## Description
This is an Event System that is implementing 'Observer Pattern' using `ScriptableObject`.

> Ref : [3 cool ways to architect your game with Scriptable Objects](https://unity3d.com/kr/how-to/architect-with-Scriptable-Objects?utm_campaign=saas_global_nurture_2018-Paid-subs-CLC-Monthly&utm_content=2018-CLC-Monthly-programmer-architect-with-Scriptable-Objects-v2&utm_medium=email&utm_source=Eloqua)

You can create an event 'asset' in the project folder, and reference it from any GameObjects in any Scenes. 

씬 전역/ 여러 씬에서 참조하고자 하는 이벤트(`OnGameStarted`, `OnGameOver` 등)들을 `ScriptableObject`를 이용하여 ‘애셋’저럼 프로젝트에 저장해 두고, 그것에 접근해야 하는 게임오브젝트들 (UI,  사운드 컨트롤 등등)에 별도의 이벤트리스너를 붙여서 해당 리스너가 이벤트를 전달해주는 중간자 역할을 하도록 해줍니다.

**Advantages**
1. **Modular**  No direct references are needed between GameObject instances. This makes game objects easy to be saved as prefabs.
2. **Editable** Change in one script doesn't affect others.
3. **Debuggable** Modulized scripts are easy to debug.
4. Non-developer-friendly : Exposed in the inspector.

## Usage
1. OmniEvent Assets
	- Right-click on the Project panel, and Select 'Omni Events/...' to create an event asset.
	- Various types of parameters are supported.
2. OmniEventListener Components
	- Add an OmniEventListener component of right parameter to a GameObject, and assign event asset(s).
	- Add any public method or property of the same parameter to `Invoked` UnityEvent.
3. GameEventInvoker Components
	- Inspector helper components for debugging / easy invoking.