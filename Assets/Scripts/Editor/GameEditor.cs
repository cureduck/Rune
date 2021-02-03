using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class GameEditor : OdinMenuEditorWindow
    {
        [MenuItem("Game/Editor")]
        protected static void Open()
        {
            var window = GetWindow<GameEditor>();
            window.position = GUIHelper.GetEditorWindowRect().AlignCenter(800, 500);
        }

        protected override OdinMenuTree BuildMenuTree()
        {
            var tree=new OdinMenuTree(true);
            tree.DefaultMenuStyle.IconOffset = 28f;
            tree.Config.DrawSearchToolbar = true;
            
            SpeciesOverview.Instance.UpdateSpeciesOverview();
            tree.Add("Specieses", new SpeciesTable(SpeciesOverview.Instance.AllSpecieses));
            
            return tree;
        }
    }
}
