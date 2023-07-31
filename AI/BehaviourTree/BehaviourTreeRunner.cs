using System.Collections;
using System.Collections.Generic;
using GLib.AI.BehaviourTree;
using GLib.AI.BehaviourTree.Nodes;
using UnityEngine;

public class BehaviourTreeRunner : MonoBehaviour
{
    public BehaviourTree tree;

    void Start()
    {
        tree = tree.Clone();
    }

    // Update is called once per frame
    void Update()
    {
        tree.Update();
    }
}