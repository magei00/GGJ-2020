// GENERATED AUTOMATICALLY FROM 'Assets/Settings/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Core"",
            ""id"": ""fe54937c-e0e9-4fca-9c72-ad5a37d69a5d"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Value"",
                    ""id"": ""9618f1fe-232c-4152-b452-a383aca2d613"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6601b236-4da5-454b-83e3-fe9bd4885f65"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Core
        m_Core = asset.FindActionMap("Core", throwIfNotFound: true);
        m_Core_Select = m_Core.FindAction("Select", throwIfNotFound: true);
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

    // Core
    private readonly InputActionMap m_Core;
    private ICoreActions m_CoreActionsCallbackInterface;
    private readonly InputAction m_Core_Select;
    public struct CoreActions
    {
        private @InputMaster m_Wrapper;
        public CoreActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Core_Select;
        public InputActionMap Get() { return m_Wrapper.m_Core; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CoreActions set) { return set.Get(); }
        public void SetCallbacks(ICoreActions instance)
        {
            if (m_Wrapper.m_CoreActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_CoreActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_CoreActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_CoreActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_CoreActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public CoreActions @Core => new CoreActions(this);
    public interface ICoreActions
    {
        void OnSelect(InputAction.CallbackContext context);
    }
}
