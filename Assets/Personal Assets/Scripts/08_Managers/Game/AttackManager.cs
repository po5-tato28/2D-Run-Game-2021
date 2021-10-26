using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public GameObject attackPrefab;
    public Transform attackPoint;


    public void EnableFireball()
    {
        Instantiate(attackPrefab, attackPoint);
    }
}
