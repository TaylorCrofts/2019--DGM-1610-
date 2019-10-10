using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
	public List<WeaponData> weapon;
	public FloatData health;
	public Clothesdata shirt;
	public Clothesdata pants;
	
	public void instancePlayer()
	{
		var newPlayer=Instantiate(prefab);
		var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
		newSprite.color = color;
		newSprite.sprite = sprite;
	}

}
