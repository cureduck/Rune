using System;
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
            
            
        }
    }
}