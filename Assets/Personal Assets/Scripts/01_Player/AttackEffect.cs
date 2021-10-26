using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEffect : MonoBehaviour
{
    private Vector3 pos;
    public Transform attackPoint;

    private void OnEnable()
    {
        pos = transform.position;
    }
    private void OnDisable()
    {
        transform.localPosition = new Vector3(0,0,0);
    }

    void Update()
    {
        pos.x += (Time.deltaTime * 1f);
        transform.position = pos;

        if (transform.position.x >= 6.0f)
        {
            DisableFireball();
        }
    }

    private void OnTrigger(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Debug.Log("enemy");
            DisableFireball();
        }
    }

    public void DisableFireball()
    {
        gameObject.SetActive(false);
    }
}
