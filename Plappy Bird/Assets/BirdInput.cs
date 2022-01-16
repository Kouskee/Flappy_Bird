// GENERATED AUTOMATICALLY FROM 'Assets/BirdInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BirdInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BirdInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BirdInput"",
    ""maps"": [
        {
            ""name"": ""BirdMovement"",
            ""id"": ""75ed89eb-4d4a-429a-a381-8c44face8a49"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bb28c674-ae3e-438b-a4b1-baa39cb1075d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1fa8ebbc-ffd6-4e1c-9a20-45476851c981"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BirdMovement
        m_BirdMovement = asset.FindActionMap("BirdMovement", throwIfNotFound: true);
        m_BirdMovement_Jump = m_BirdMovement.FindAction("Jump", throwIfNotFound: true);
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

    // BirdMovement
    private readonly InputActionMap m_BirdMovement;
    private IBirdMovementActions m_BirdMovementActionsCallbackInterface;
    private readonly InputAction m_BirdMovement_Jump;
    public struct BirdMovementActions
    {
        private @BirdInput m_Wrapper;
        public BirdMovementActions(@BirdInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_BirdMovement_Jump;
        public InputActionMap Get() { return m_Wrapper.m_BirdMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdMovementActions set) { return set.Get(); }
        public void SetCallbacks(IBirdMovementActions instance)
        {
            if (m_Wrapper.m_BirdMovementActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_BirdMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BirdMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BirdMovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BirdMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public BirdMovementActions @BirdMovement => new BirdMovementActions(this);
    public interface IBirdMovementActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}
