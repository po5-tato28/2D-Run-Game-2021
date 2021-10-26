using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    bool hit = false;

    private void OnEnable()
    {
        hit = false;
    }

    void Update()
    {
        if (hit == true) return;

        Vector3 pos = transform.position;
        pos.x -= (Time.deltaTime * 4.2f);
        transform.position = pos;

        if (transform.position.x <= -9.0f)
        {
            ObjectHide();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fireball"))
        {
            hit = true;

            GetComponent<Animator>().SetTrigger("Hit");
            Invoke("ObjectHide", 0.6f);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            hit = true;
        }
    }

    public void ObjectHide()
    {
        gameObject.SetActive(false);
    }
}
