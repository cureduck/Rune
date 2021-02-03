using Unity.Entities;

namespace Game.ECS
{
    public struct StatusComponent:IComponentData
    {
        public int MaxHp;
        public int CurHp;
        public int MaxSp;
        public int CurSp;
    }
}