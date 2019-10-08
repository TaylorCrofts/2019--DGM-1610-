using UnityEngine;
[CreateAssetMenu]
public class PlayerData : GameArtData
{
	public WeaponData weapon;
	
	public void instancePlayer()
	{
		var newPlayer=Instantiate(prefab);
		var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
		newSprite.color = color;
		newSprite.sprite = sprite;
	}

}
