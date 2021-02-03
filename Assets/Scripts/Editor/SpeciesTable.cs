using System.Collections.Generic;
using System.Linq;
using Game.ECS;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR

namespace Editor
{
        public class SpeciesTable
    {
        [TableList(IsReadOnly = true, AlwaysExpanded = true), ShowInInspector]
        private readonly List<SpeciesWrapper> allSpecieses;

        public Species this[int index]
        {
            get { return this.allSpecieses[index].Species; }
        }

        public SpeciesTable(IEnumerable<Species> specieses)
        {
            this.allSpecieses = specieses.Select(x => new SpeciesWrapper(x)).ToList();
        }

        private class SpeciesWrapper
        {
            private Species species; // Character is a ScriptableObject and would render a unity object
                                         // field if drawn in the inspector, which is not what we want.

            public Species Species
            {
                get { return this.species; }
            }

            public SpeciesWrapper(Species species)
            {
                this.species = species;
            }

            [ShowInInspector]
            public SpStrComponent spStr
            {
                get=>species.spStr;
                set { species.spStr = value; }
            }
        }
    }
}

#endif
