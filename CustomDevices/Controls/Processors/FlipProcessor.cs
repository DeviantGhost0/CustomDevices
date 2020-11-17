using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CustomDevices.Controls.Processors
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    public class FlipProcessor : InputProcessor<float>
    {
#if UNITY_EDITOR
        static FlipProcessor()
        {
            Initialize();
        }
#endif

        [RuntimeInitializeOnLoadMethod]
        static void Initialize()
        {
            InputSystem.RegisterProcessor<FlipProcessor>();
        }

        [Tooltip("Does stuff")]
        public float maxValue = 1;

        public override float Process(float value, InputControl control)
        {
            return this.maxValue - value;
        }
    }
}