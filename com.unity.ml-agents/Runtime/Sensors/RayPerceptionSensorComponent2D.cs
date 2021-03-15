#if MLA_UNITY_PHYSICS_MODULE || !UNITY_2019_4_OR_NEWER
#define MLA_UNITY_PHYSICS_MODULE_ENABLED
#endif

#if MLA_UNITY_PHYSICS2D_MODULE || !UNITY_2019_4_OR_NEWER
#define MLA_UNITY_PHYSICS2D_MODULE_ENABLED
#endif

#if MLA_UNITY_PHYSICS2D_MODULE_ENABLED
using UnityEngine;

namespace Unity.MLAgents.Sensors
{
    /// <summary>
    /// A component for 2D Ray Perception.
    /// </summary>
    [AddComponentMenu("ML Agents/Ray Perception Sensor 2D", (int)MenuGroup.Sensors)]
    public class RayPerceptionSensorComponent2D : RayPerceptionSensorComponentBase
    {
        /// <summary>
        /// Initializes the raycast sensor component.
        /// </summary>
        public RayPerceptionSensorComponent2D()
        {
            // Set to the 2D defaults (just in case they ever diverge).
            RayLayerMask = Physics2D.DefaultRaycastLayers;
        }

        /// <inheritdoc/>
        public override RayPerceptionCastType GetCastType()
        {
            return RayPerceptionCastType.Cast2D;
        }
    }
}
#endif // MLA_UNITY_PHYSICS2D_MODULE
