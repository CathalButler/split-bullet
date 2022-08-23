//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/Main/InputSystem/InputControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Profiler"",
            ""id"": ""f49beba3-b51d-4298-91c1-76778cf0afc4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""433e7d36-1d4a-4534-ac5f-90e04cb514fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveLeftStick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9e617f3a-3ce6-45a1-938f-ab6fa8b0afc6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""86b20cce-3804-4f17-af82-f1ed2f89eea2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4275ba1f-f1ae-452f-a91d-2c064cfad8d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""13a66fc3-9267-455b-87d3-6f1ac77a8b4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""dce4a3d9-b137-4cfb-ab26-532bd1b7f30e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""904d81cd-7eec-474c-b5ac-3d37f62febae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LowProfile"",
                    ""type"": ""Button"",
                    ""id"": ""19cd6377-8830-4d49-a88e-a34d2bfee9bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HighProfile"",
                    ""type"": ""Button"",
                    ""id"": ""40dfe04b-11a6-4d1f-a760-b1c23c347b38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FirePistol"",
                    ""type"": ""Button"",
                    ""id"": ""41a7b749-c8d5-4e2a-9144-99d417f53f70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""805238ac-9544-4d8a-b9d3-dfef456d24ba"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6c7390f3-8675-42a0-a9be-fe20fa49dccd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b284b39f-3b40-47fd-a59c-8737b6ba6b3c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3743fd10-e77b-4872-8f30-3e7ee8c58136"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""881d10fe-0695-4ce1-94e2-40703ea34e7f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e8315c92-21d6-49ea-a337-c4a3b9cfd537"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""460637f6-2000-4eda-8a1c-08d21d55b730"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fd0f057-9fb2-47af-96fe-7b1bebe55e6b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1d7a841-5b08-43f5-8047-1faec1b2f000"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""972f6508-4b65-49b7-aee4-03366c88a957"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc6501fd-528d-4137-8f88-67db88a91ca9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11c09771-3e88-4193-b66c-35ca9cdb4295"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e511947b-fd26-4aa4-ba99-9729a82d9c06"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58aa1834-296c-4c26-8745-24a481d2f2bf"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91c0cd2a-9482-4551-bde9-e591c135604c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d947b18-9bcc-41d2-9783-b4032c85daec"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d6bb401-c47c-412f-9def-29f0768d437a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""207ac77f-2f9d-42bb-9cb1-c1df2661c4ec"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighProfile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06b943cb-aa1e-4d2e-881d-abcb9d3c1be3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HighProfile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5074b020-f7af-4b01-8560-19c8a6ec93c6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LowProfile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc754bc1-4975-4647-a1ce-221b54b7f2aa"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LowProfile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""37833fe8-e40d-4620-b32a-549d55f07a27"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""190960ab-bd61-464c-84c7-b2e63be52d73"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d66258c9-dd90-47b8-9b86-53b92ea9b675"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3cfadce8-6a3e-4ed5-bd54-d490d01c9faa"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""22a97324-b0a5-42ad-b3ab-a0aff0f36361"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e39bfa88-64c0-429c-9ace-dcd9d58faedb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirePistol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f934ab54-97aa-4928-9445-0cfb2cae9c45"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirePistol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acdb7c19-a96a-40ef-acb6-7fea1188a0bb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirePistol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Testing"",
            ""id"": ""6ee69d26-7841-44db-9308-be90da9d70b8"",
            ""actions"": [
                {
                    ""name"": ""NoirVFX"",
                    ""type"": ""Button"",
                    ""id"": ""3b41821b-c552-4176-b7df-c7d2b3474d64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f4b02ae-38d1-49e3-ac29-11331ccf9ba0"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NoirVFX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Profiler
        m_Profiler = asset.FindActionMap("Profiler", throwIfNotFound: true);
        m_Profiler_Movement = m_Profiler.FindAction("Movement", throwIfNotFound: true);
        m_Profiler_MoveLeftStick = m_Profiler.FindAction("MoveLeftStick", throwIfNotFound: true);
        m_Profiler_Run = m_Profiler.FindAction("Run", throwIfNotFound: true);
        m_Profiler_Look = m_Profiler.FindAction("Look", throwIfNotFound: true);
        m_Profiler_Jump = m_Profiler.FindAction("Jump", throwIfNotFound: true);
        m_Profiler_Attack = m_Profiler.FindAction("Attack", throwIfNotFound: true);
        m_Profiler_Dodge = m_Profiler.FindAction("Dodge", throwIfNotFound: true);
        m_Profiler_LowProfile = m_Profiler.FindAction("LowProfile", throwIfNotFound: true);
        m_Profiler_HighProfile = m_Profiler.FindAction("HighProfile", throwIfNotFound: true);
        m_Profiler_FirePistol = m_Profiler.FindAction("FirePistol", throwIfNotFound: true);
        // Testing
        m_Testing = asset.FindActionMap("Testing", throwIfNotFound: true);
        m_Testing_NoirVFX = m_Testing.FindAction("NoirVFX", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Profiler
    private readonly InputActionMap m_Profiler;
    private IProfilerActions m_ProfilerActionsCallbackInterface;
    private readonly InputAction m_Profiler_Movement;
    private readonly InputAction m_Profiler_MoveLeftStick;
    private readonly InputAction m_Profiler_Run;
    private readonly InputAction m_Profiler_Look;
    private readonly InputAction m_Profiler_Jump;
    private readonly InputAction m_Profiler_Attack;
    private readonly InputAction m_Profiler_Dodge;
    private readonly InputAction m_Profiler_LowProfile;
    private readonly InputAction m_Profiler_HighProfile;
    private readonly InputAction m_Profiler_FirePistol;
    public struct ProfilerActions
    {
        private @InputControls m_Wrapper;
        public ProfilerActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Profiler_Movement;
        public InputAction @MoveLeftStick => m_Wrapper.m_Profiler_MoveLeftStick;
        public InputAction @Run => m_Wrapper.m_Profiler_Run;
        public InputAction @Look => m_Wrapper.m_Profiler_Look;
        public InputAction @Jump => m_Wrapper.m_Profiler_Jump;
        public InputAction @Attack => m_Wrapper.m_Profiler_Attack;
        public InputAction @Dodge => m_Wrapper.m_Profiler_Dodge;
        public InputAction @LowProfile => m_Wrapper.m_Profiler_LowProfile;
        public InputAction @HighProfile => m_Wrapper.m_Profiler_HighProfile;
        public InputAction @FirePistol => m_Wrapper.m_Profiler_FirePistol;
        public InputActionMap Get() { return m_Wrapper.m_Profiler; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ProfilerActions set) { return set.Get(); }
        public void SetCallbacks(IProfilerActions instance)
        {
            if (m_Wrapper.m_ProfilerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnMovement;
                @MoveLeftStick.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnMoveLeftStick;
                @MoveLeftStick.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnMoveLeftStick;
                @MoveLeftStick.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnMoveLeftStick;
                @Run.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnRun;
                @Look.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnAttack;
                @Dodge.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnDodge;
                @LowProfile.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnLowProfile;
                @LowProfile.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnLowProfile;
                @LowProfile.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnLowProfile;
                @HighProfile.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnHighProfile;
                @HighProfile.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnHighProfile;
                @HighProfile.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnHighProfile;
                @FirePistol.started -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnFirePistol;
                @FirePistol.performed -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnFirePistol;
                @FirePistol.canceled -= m_Wrapper.m_ProfilerActionsCallbackInterface.OnFirePistol;
            }
            m_Wrapper.m_ProfilerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MoveLeftStick.started += instance.OnMoveLeftStick;
                @MoveLeftStick.performed += instance.OnMoveLeftStick;
                @MoveLeftStick.canceled += instance.OnMoveLeftStick;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
                @LowProfile.started += instance.OnLowProfile;
                @LowProfile.performed += instance.OnLowProfile;
                @LowProfile.canceled += instance.OnLowProfile;
                @HighProfile.started += instance.OnHighProfile;
                @HighProfile.performed += instance.OnHighProfile;
                @HighProfile.canceled += instance.OnHighProfile;
                @FirePistol.started += instance.OnFirePistol;
                @FirePistol.performed += instance.OnFirePistol;
                @FirePistol.canceled += instance.OnFirePistol;
            }
        }
    }
    public ProfilerActions @Profiler => new ProfilerActions(this);

    // Testing
    private readonly InputActionMap m_Testing;
    private ITestingActions m_TestingActionsCallbackInterface;
    private readonly InputAction m_Testing_NoirVFX;
    public struct TestingActions
    {
        private @InputControls m_Wrapper;
        public TestingActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @NoirVFX => m_Wrapper.m_Testing_NoirVFX;
        public InputActionMap Get() { return m_Wrapper.m_Testing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestingActions set) { return set.Get(); }
        public void SetCallbacks(ITestingActions instance)
        {
            if (m_Wrapper.m_TestingActionsCallbackInterface != null)
            {
                @NoirVFX.started -= m_Wrapper.m_TestingActionsCallbackInterface.OnNoirVFX;
                @NoirVFX.performed -= m_Wrapper.m_TestingActionsCallbackInterface.OnNoirVFX;
                @NoirVFX.canceled -= m_Wrapper.m_TestingActionsCallbackInterface.OnNoirVFX;
            }
            m_Wrapper.m_TestingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NoirVFX.started += instance.OnNoirVFX;
                @NoirVFX.performed += instance.OnNoirVFX;
                @NoirVFX.canceled += instance.OnNoirVFX;
            }
        }
    }
    public TestingActions @Testing => new TestingActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IProfilerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMoveLeftStick(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnLowProfile(InputAction.CallbackContext context);
        void OnHighProfile(InputAction.CallbackContext context);
        void OnFirePistol(InputAction.CallbackContext context);
    }
    public interface ITestingActions
    {
        void OnNoirVFX(InputAction.CallbackContext context);
    }
}
