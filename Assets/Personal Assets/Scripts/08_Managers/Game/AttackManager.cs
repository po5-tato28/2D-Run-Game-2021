using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public GameObject attackPrefab;
    public Transform attackPoint;

    private List<GameObject> attackList;

    private void Awake()
    {
        attackList = new List<GameObject>();
    }

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject attack = Instantiate(attackPrefab, attackPoint) as GameObject;
            attack.SetActive(false);
            attackList.Add(attack);
        }
    }


    public void EnableFireball()
    {
        foreach(GameObject att in attackList)
        {
            if(!att.activeSelf)
            {
                att.SetActive(true);
                break;
            }
        }
    }
}
