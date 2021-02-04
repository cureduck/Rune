using Unity.Entities;

namespace Game.ECS
{
    public struct InsComponent:IComponentData
    {
        public Entity target;
        public Ins ins;
        public Entity param;
    }

    public enum Ins
    {
        Eat,
        Farm,
        Fish,
        Walk,
        Sleep,
        Fertilize
    }
}