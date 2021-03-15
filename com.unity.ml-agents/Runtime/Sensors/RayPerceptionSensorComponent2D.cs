#if MLA_UNITY_PHYSICS_MODULE || !UNITY_2019_4_OR_NEWER
#define MLA_UNITY_PHYSICS_MODULE_ENABLED
#endif

#if MLA_UNITY_PHYSICS2D_MODULE || !UNITY_2019_4_OR_NEWER
#define MLA_UNITY_PHYSICS2D_MODULE_ENABLED
#endif

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
#if MLA_UNITY_PHYSICS2D_MODULE_ENABLED
            RayLayerMask = Physics2D.DefaultRaycastLayers;
#else
            RayLayerMask = -5;
#endif
        }

        /// <inheritdoc/>
        public override RayPerceptionCastType GetCastType()
        {
            return RayPerceptionCastType.Cast2D;
        }
    }
}
