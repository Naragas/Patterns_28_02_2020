using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "SpaceshipData", menuName = "Data/Player/ShaceshipData", order = 0)]
    public class SpaceshipData : ScriptableObject
    {
        [Range(1f, 6f)] public float Speed;
        [Range(1f, 6f)] public float Acceleration;
        [Range(0f, 100f)] public float Hp;
        [Range(1f, 10f)] public float Force;
        
    }
}