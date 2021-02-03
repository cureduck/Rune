using Unity.Entities;

namespace Game.ECS
{
    public struct SkillComponent:IComponentData
    {
        public int Fish;
        public int Farm;
        public int Forge;
        public int Fight;
        public int Survive;
    }
}