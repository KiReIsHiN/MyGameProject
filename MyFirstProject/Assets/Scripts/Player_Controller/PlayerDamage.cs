using UnityEngine;

[AddComponentMenu("My Components/Scripts/Player_Controller/CharacterMovement")]
public class PlayerDamage : MonoBehaviour
{

    public int Damage = 10;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            CharacterMovement.Player._healthPower -= Damage;
        }
    }
}
