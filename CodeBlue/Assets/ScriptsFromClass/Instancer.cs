using UnityEngine;

public class Instancer : MonoBehaviour
{
    public ApplyForce ammo;


    public void Fire()
   {

       Instantiate(ammo,transform.position, Quaternion.identity);

   }
}
