using Unity.Entities;

namespace Game.ECS
{
    public struct SpComponent:IComponentData
    {
        public Gift gift;
    }

    public enum Gift
    {
        Strong,
        Tough
    }
}