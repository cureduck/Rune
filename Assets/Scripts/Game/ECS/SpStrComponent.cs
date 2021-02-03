using Unity.Entities;

namespace Game.ECS
{
    public struct SpStrComponent:IComponentData
    {
        public int hp;
        public int sp;
        public Gift gift;
    }

    public enum Gift
    {
        Strong,
        Tough
    }
}