using System;
using Game.ECS;
using Unity.Entities;
using UnityEngine;

namespace Game
{
    public class EntitySpawner : MonoBehaviour
    {
        private EntityManager em;
        
        
        
        private void Awake()
        {
            em = World.DefaultGameObjectInjectionWorld.EntityManager;

            EntityArchetype unitArch = em.CreateArchetype(
                typeof(SpComponent),
                typeof(BuffComponent),
                typeof(SkillComponent),
                typeof(StatusComponent),
                typeof(CoordComponent)
                );

            em.CreateEntity(unitArch);
        }
    }
}