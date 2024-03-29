//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/CharacterSceneScripts/Input/PlayerInput.inputactions
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

namespace CharacterSceneScripts
{
    public partial class @PlayerInput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""5153cd83-84a1-4924-a220-04ee82e29993"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""55ad5b2d-4774-4ec9-875c-9729fa3c4a24"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7c7383df-7704-450e-8edb-94919e89e71b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Button"",
                    ""id"": ""ebfdf9c5-286c-4bea-a6ba-a0197105e15e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Button"",
                    ""id"": ""b9a22c76-b9db-4530-8b8a-e5c4d37c262e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ff9a737c-f566-478b-8912-6e5204f0fd2c"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""44c5c046-c07f-4349-adb8-f8bec64338b2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dbdef79b-0006-4000-977c-464298189476"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ac915b0a-3133-4da6-a483-e34534872e80"",
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
                    ""id"": ""7414d283-0aca-459f-a512-387164ce38d8"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""928ea877-2246-44e7-9167-4862e990ec9a"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Movement
            m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
            m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
            m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
            m_Movement_Acceleration = m_Movement.FindAction("Acceleration", throwIfNotFound: true);
            m_Movement_Walk = m_Movement.FindAction("Walk", throwIfNotFound: true);
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

        // Movement
        private readonly InputActionMap m_Movement;
        private IMovementActions m_MovementActionsCallbackInterface;
        private readonly InputAction m_Movement_Move;
        private readonly InputAction m_Movement_Jump;
        private readonly InputAction m_Movement_Acceleration;
        private readonly InputAction m_Movement_Walk;
        public struct MovementActions
        {
            private @PlayerInput m_Wrapper;
            public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Movement_Move;
            public InputAction @Jump => m_Wrapper.m_Movement_Jump;
            public InputAction @Acceleration => m_Wrapper.m_Movement_Acceleration;
            public InputAction @Walk => m_Wrapper.m_Movement_Walk;
            public InputActionMap Get() { return m_Wrapper.m_Movement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
            public void SetCallbacks(IMovementActions instance)
            {
                if (m_Wrapper.m_MovementActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                    @Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    @Acceleration.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnAcceleration;
                    @Acceleration.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnAcceleration;
                    @Acceleration.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnAcceleration;
                    @Walk.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                    @Walk.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                    @Walk.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                }
                m_Wrapper.m_MovementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Acceleration.started += instance.OnAcceleration;
                    @Acceleration.performed += instance.OnAcceleration;
                    @Acceleration.canceled += instance.OnAcceleration;
                    @Walk.started += instance.OnWalk;
                    @Walk.performed += instance.OnWalk;
                    @Walk.canceled += instance.OnWalk;
                }
            }
        }
        public MovementActions @Movement => new MovementActions(this);
        public interface IMovementActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnAcceleration(InputAction.CallbackContext context);
            void OnWalk(InputAction.CallbackContext context);
        }
    }
}
