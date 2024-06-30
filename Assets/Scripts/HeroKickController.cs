using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeroKickController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject rockPrefab;
    [SerializeField] private Transform pointTransform;

    private GameObject newRock;
  

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Kick",true);
            newRock = Instantiate(rockPrefab, pointTransform.position, Quaternion.Euler(90f,0,0));
            newRock.transform.DOMoveY(1, 1);
        } 
    }

    public void KickTheRock()
    {
        newRock.transform.DOMoveZ(20, 1f);
    }

    public void ReturnIdleAnim()
    {
        animator.SetBool("Kick",false);
    }
}
