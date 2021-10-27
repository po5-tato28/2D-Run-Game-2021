using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEffect : MonoBehaviour
{    
    private Vector3 pos;
    public Transform attackPoint;

    bool hit = false;

    private void OnEnable()
    {
        hit = false;
        pos = transform.position;        
    }
    private void OnDisable()
    {
        transform.localPosition = new Vector3(0,0,0);
    }

    void Update()
    {
        if (hit == true) return;
        pos.x += (Time.deltaTime * 1f);
        transform.position = pos;

        if (transform.position.x >= 6.6f)
        {
            DisableFireball();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("enemy");

            hit = true;
            ScoreManager.instance.AddScore(100);

            GetComponent<Animator>().SetTrigger("Hit");
            //Invoke("DisableFireball", 0.8f);
        }
    }

    public void DisableFireball()
    {
        gameObject.SetActive(false);
    }
}
