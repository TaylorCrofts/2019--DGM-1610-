using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
	public UnityAction<GameObject> instanceAction;
	
	public List<WeaponData> weapon;
	public FloatData health;
	public Clothesdata shirt;
	public Clothesdata pants;
	
	public void InstancePlayer()
	{
		var newPlayer=Instantiate(prefab);
		var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
		newSprite.color = color;
		newSprite.sprite = sprite;
		instanceAction(newPlayer);
	}

}
