using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[AddComponentMenu("My Components/Scripts/Level_Intro/Jill_Controller")]
public class Jill_Attack : MonoBehaviour
{
    public Jill_Controller JillController;

    void Start()
    {
        JillController = GameObject.FindGameObjectWithTag("JillZombie").GetComponent<Jill_Controller>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(TheSequence());
        }
    }

    IEnumerator TheSequence()
    {
        JillController._anim.SetBool("isAttacking", true);
        yield return new WaitForSeconds(0.5f);
        JillController.AS.PlayOneShot(JillController.AC);
        yield return new WaitForSeconds(2.80f);
        JillController._agent.speed = 2f;
    }

}
