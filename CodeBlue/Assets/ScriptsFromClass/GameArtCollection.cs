using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        if (!collectionList.Contains(obj))
        {
            collectionList.Add(obj);
        }
    }

    public void RemoveLastItem()
    {
        if (collectionList.Capacity != 0)
        {
            collectionList.RemoveAt(collectionList.Count-1);
        }
    }
}
