using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
	public List<GameArtData> artCollection;
	public void AddArtData(GameArtData obj)
	{
		artCollection.Add(obj);
		obj.collected = true;
	}
}
