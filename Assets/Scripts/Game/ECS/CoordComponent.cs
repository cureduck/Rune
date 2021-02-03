using Unity.Entities;
using UnityEngine;

namespace Game.ECS
{
    public struct CoordComponent:IComponentData
    {
        public Vector2 coord;
    }
}