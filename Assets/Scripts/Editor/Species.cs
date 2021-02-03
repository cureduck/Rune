using Game.ECS;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Editor
{
    [CreateAssetMenu(fileName = "Human", menuName = "Game/Species", order = 0)]
    public class Species : SerializedScriptableObject
    {
        public StatusComponent status;
    }
}