using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwan_Bugs : MonoBehaviour
{
   public Transform[] spwanLocation;
   public GameObject[] whatToSpwanPrefab;
   public GameObject[] whatToSpawnClone;
   
   void Start() {
      
       StartCoroutine(bugsWave ());
   }

   void spwan () {
       whatToSpawnClone[Random.Range(0,3)] =
        Instantiate(whatToSpwanPrefab[Random.Range(0,3)],
        spwanLocation[Random.Range(0,6)].transform.position, Quaternion.Euler(0,0,0))
        as GameObject;
   }

   IEnumerator bugsWave () {
       while (true)
       {
           yield return new WaitForSeconds(Random.Range(1f,1.25f));
           spwan();
       } 
}
}
