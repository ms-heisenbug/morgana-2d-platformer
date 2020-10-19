// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""4d729629-5156-4444-b6cc-2909ff03c3cc"",
            ""actions"": [
                {
                    ""name"": ""Sideways"",
                    ""type"": ""PassThrough"",
                    ""id"": ""434ba5f4-1294-4768-a00c-40bafe494ab8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8b1d6ca8-7e61-4bdc-8883-59cc0a286d0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DoubleJump"",
                    ""type"": ""Button"",
                    ""id"": ""ae1fd5b5-07f2-4d50-ac3e-b059484f3b07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""3cb22411-c6d5-40a8-a5bf-b3313de66b39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftRight"",
                    ""id"": ""0fcc2080-5212-47e8-bb52-bf2e701830f7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideways"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b76b2fb6-b66c-483d-99f4-f90994438341"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f1d18473-7a3c-4126-9c83-7ea5479a04e6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""85385450-ad56-4461-8dd0-5153dc853686"",
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
                    ""id"": ""65648e9d-4b49-4399-b9a6-347065b786c3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DoubleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29f30d04-70bb-46e8-9919-472286fd41cf"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Sideways = m_Move.FindAction("Sideways", throwIfNotFound: true);
        m_Move_Jump = m_Move.FindAction("Jump", throwIfNotFound: true);
        m_Move_DoubleJump = m_Move.FindAction("DoubleJump", throwIfNotFound: true);
        m_Move_Slide = m_Move.FindAction("Slide", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Sideways;
    private readonly InputAction m_Move_Jump;
    private readonly InputAction m_Move_DoubleJump;
    private readonly InputAction m_Move_Slide;
    public struct MoveActions
    {
        private @PlayerControls m_Wrapper;
        public MoveActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Sideways => m_Wrapper.m_Move_Sideways;
        public InputAction @Jump => m_Wrapper.m_Move_Jump;
        public InputAction @DoubleJump => m_Wrapper.m_Move_DoubleJump;
        public InputAction @Slide => m_Wrapper.m_Move_Slide;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Sideways.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnSideways;
                @Sideways.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnSideways;
                @Sideways.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnSideways;
                @Jump.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @DoubleJump.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnDoubleJump;
                @DoubleJump.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnDoubleJump;
                @DoubleJump.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnDoubleJump;
                @Slide.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnSlide;
                @Slide.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnSlide;
                @Slide.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnSlide;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Sideways.started += instance.OnSideways;
                @Sideways.performed += instance.OnSideways;
                @Sideways.canceled += instance.OnSideways;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @DoubleJump.started += instance.OnDoubleJump;
                @DoubleJump.performed += instance.OnDoubleJump;
                @DoubleJump.canceled += instance.OnDoubleJump;
                @Slide.started += instance.OnSlide;
                @Slide.performed += instance.OnSlide;
                @Slide.canceled += instance.OnSlide;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnSideways(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDoubleJump(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
    }
}
