using System.Collections.Generic;
using UnityEngine;

namespace ScriptsFromClass
{
    [CreateAssetMenu]
    public class Lists : ScriptableObject
    {
        public List<string> stringList;
        public List<int> intList;
        public List<float> floatList;

        public List<GameObject> gameObjectList;
        public List<FloatData> floatDataList;
    }
}
