using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject enemy;
    private float createtime;

    private List<GameObject> Stonlist;
    private float createtick;

    //private GameObject[] StonArray;
    // Use this for initialization
    void Awake()
    {
        createtick = 0.0f;
        createtime = 1.0f;
        //StonArray
        //Stonlist.Clear();
        Stonlist = new List<GameObject>();

        for (int i = 0; i < 10; i++)
        {
            GameObject ston = Instantiate(enemy, Vector3.zero, Quaternion.identity) as GameObject;
            ston.transform.parent = transform;
            ston.SetActive(false);
            Stonlist.Add(ston);
        }
    }

    // Update is called once per frame
    void Update()
    {
        createtick += Time.deltaTime;

        if (createtick >= createtime)
        {
            createtime = Random.Range(3.0f, 4.0f);

            createtick = 0.0f;

            foreach (GameObject st in Stonlist) //list array ตัดู ตส.
            {
                if (!st.activeSelf)
                {
                    st.transform.position = new Vector3(6.6f, -3f, 0.0f);
                    st.SetActive(true);
                    break;
                }
            }
            /*
            for (int i = 0; i < Stonlist.Count; i++)
            {

            }*/
        }
    }
}
