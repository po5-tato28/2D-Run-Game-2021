using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject enemy;
    private List<GameObject> enemyList;

    private float createtime;
    private float createtick;

    void Awake()
    {   
        createtick = 0.0f;
        createtime = 1.0f;
        
        enemyList = new List<GameObject>();

        for (int i = 0; i < 10; i++)
        {
            GameObject enemies = Instantiate(enemy, Vector3.zero, Quaternion.identity) as GameObject;
            enemies.transform.parent = transform;
            enemies.SetActive(false);
            enemyList.Add(enemies);
        }
    }

    void Update()
    {
        createtick += Time.deltaTime;

        if (createtick >= createtime)
        {
            createtime = Random.Range(3.0f, 4.0f);

            createtick = 0.0f;

            foreach (GameObject st in enemyList) //list array ตัดู ตส.
            {
                if (!st.activeSelf)
                {
                    st.transform.position = new Vector3(6.6f, -3f, 0.0f);
                    st.SetActive(true);
                    break;
                }
            }
        }
    }

    public void DisableObject()
    {
        gameObject.SetActive(false);
    }
}
