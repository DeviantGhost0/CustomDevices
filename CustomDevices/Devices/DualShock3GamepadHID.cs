using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.Layouts;

namespace CustomDevices.Devices
{
    [InputControlLayout(displayName = "PS3 SIXAXIS Controller", stateType = typeof(DualShock3HIDInputReport))]
    #if UNITY_EDITOR
    [InitializeOnLoad]
    #endif
    public class DualShock3GamepadHID : DualShockGamepad {
        static DualShock3GamepadHID()
        {
            InputSystem.RegisterLayout<DualShock3GamepadHID>(
                matches: new InputDeviceMatcher()
                    .WithInterface("HID")
                    .WithCapability("vendorId", "0x054C")
                    .WithCapability("productId", "0x0268"));   
        }
        
        [RuntimeInitializeOnLoadMethod]
        static void Init() {}
    }
}