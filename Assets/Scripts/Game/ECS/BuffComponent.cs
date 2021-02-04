using Unity.Entities;

namespace Game.ECS
{
    public struct BuffComponent : IComponentData
    {
        public Buff Poison;
        public Buff Slow;
        public Buff Crazy;
    }

    public struct Buff
    {
        public int level;
        public float maxDuration;
        public float leftDuration;
        public int stack;
    }
    
}