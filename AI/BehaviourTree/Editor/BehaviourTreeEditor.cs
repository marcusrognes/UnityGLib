using System;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.UIElements;

namespace GLib.AI.BehaviourTree.Editor
{
    public class BehaviourTreeEditor : EditorWindow
    {
        [SerializeField] private VisualTreeAsset m_VisualTreeAsset = default;

        private BehaviourTree tree;


        private BehaviourTreeView treeView;
        private InspectorView inspectorView;

        //[MenuItem("GLib/BehaviourTree/Editor")]
        public static void OpenWindow(BehaviourTree selectedTree)
        {
            BehaviourTreeEditor wnd = GetWindow<BehaviourTreeEditor>();
            wnd.titleContent = new GUIContent("Behaviour Tree: " + selectedTree.name);
            wnd.SetTree(selectedTree);
        }

        [OnOpenAsset]
        public static bool OnOpenAsset(int instanceId, int line)
        {
            if (Selection.activeObject is BehaviourTree)
            {
                OpenWindow(Selection.activeObject as BehaviourTree);
                return true;
            }

            return false;
        }

        public void CreateGUI()
        {
            VisualElement root = rootVisualElement;

            m_VisualTreeAsset.CloneTree(root);

            treeView = root.Q<BehaviourTreeView>();
            treeView.OnNodeSelected = OnNodeSelectionChanged;
            inspectorView = root.Q<InspectorView>();
        }

        public void SetTree(BehaviourTree tree)
        {
            this.tree = tree;
            treeView.PopulateView(this.tree);
        }

        void OnNodeSelectionChanged(NodeView node)
        {
            inspectorView.UpdateSelection(node);
        }
    }
}