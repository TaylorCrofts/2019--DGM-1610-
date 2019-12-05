using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public ApplyForce ammo;

    // Update is called once per frame
    public void Fire()
    {
            Instantiate(ammo,transform.position, Quaternion.identity);
    }
}
