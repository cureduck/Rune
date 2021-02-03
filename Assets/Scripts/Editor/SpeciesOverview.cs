using Editor;
using Sirenix.OdinInspector;

#if UNITY_EDITOR
namespace Editor
{
    using Sirenix.Utilities;
    using System.Linq;

#if UNITY_EDITOR
    using UnityEditor;
#endif


    public class SpeciesOverview : GlobalConfig<SpeciesOverview> 
    {
        [ReadOnly]
        [ListDrawerSettings(Expanded = true)]
        public Species[] AllSpecieses;

#if UNITY_EDITOR
        [Button(ButtonSizes.Medium), PropertyOrder(-1)]
        public void UpdateSpeciesOverview()
        {
            // Finds and assigns all scriptable objects of type Character
            this.AllSpecieses = AssetDatabase.FindAssets("t:Species")
                .Select(guid => AssetDatabase.LoadAssetAtPath<Species>(AssetDatabase.GUIDToAssetPath(guid)))
                .ToArray();
        }
#endif
    }
}
#endif