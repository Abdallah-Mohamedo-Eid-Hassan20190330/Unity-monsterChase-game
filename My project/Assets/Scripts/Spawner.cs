using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterArr;
    private GameObject readyMonster;
    [SerializeField]
    private Transform leftTerminal, rightTerminal; 
    private int randomIndex , randomSide; 


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitingFun()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Coroutine to force it to wait
   IEnumerator waitingFun()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, 5));
            randomIndex = Random.Range(0, monsterArr.Length);
            randomSide = Random.Range(0, 2);
            readyMonster = Instantiate(monsterArr[randomIndex]);
            if (randomSide == 0)
            {
                readyMonster.transform.position = leftTerminal.position;
                
                //readyMonster.transform.localScale = leftTerminal.localScale;
                readyMonster.GetComponent<Monsters>().speed = Random.Range(4, 7); 

            }
            else
            {
                readyMonster.transform.position = rightTerminal.position;
                
                readyMonster.transform.localScale = rightTerminal.localScale;
                readyMonster.GetComponent<Monsters>().speed = -Random.Range(4, 7); 

            }
        }
    }
   
} // class
