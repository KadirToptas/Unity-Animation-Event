using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeroKickController : MonoBehaviour
{
    [SerializeField] private GameObject rockPrefab;
    [SerializeField] private Transform pointTransform;

    private GameObject newRock;
  

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            newRock = Instantiate(rockPrefab, pointTransform.position, Quaternion.identity);
            
        } 
    }
}
