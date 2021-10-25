using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= (Time.deltaTime * 4.2f);
        transform.position = pos;

        if (transform.position.x <= -9.0f)
        {
            ObjectHide();
        }
    }

    public void ObjectHide()
    {
        gameObject.SetActive(false);
    }
}
