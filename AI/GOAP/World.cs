using System.Collections.Generic;
using UnityEngine;

namespace GLib.AI.GOAP
{
    [CreateAssetMenu(fileName = "GOAP World", menuName = "GLIB/AI/GOAP World")]
    public class World : ScriptableObject
    {
        public Dictionary<Resource, List<ResourceSource>> resources = new Dictionary<Resource, List<ResourceSource>>();

        public void addSource(ResourceSource source)
        {
            var list = ensureAndGetList(source);

            if (!list.Contains(source))
                list.Add(source);
        }

        public void removeSource(ResourceSource source)
        {
            var list = ensureAndGetList(source);

            if (list.Contains(source))
                list.Remove(source);
        }

        private List<ResourceSource> ensureAndGetList(ResourceSource source)
        {
            var list = resources[source.resource];

            if (list == null)
            {
                resources.Add(source.resource, new List<ResourceSource>());
                list = resources[source.resource];
            }

            return list;
        }
    }
}