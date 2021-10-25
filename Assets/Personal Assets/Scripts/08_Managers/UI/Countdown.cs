using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    private int timer = 3;
    public GameObject countdown;
    private GameObject ready;
    private GameObject go;
    public GameObject objectManager;

    private void Awake()
    {
        ready = countdown.transform.GetChild(0).gameObject;
        go = countdown.transform.GetChild(1).gameObject;
    }

    private void Start()
    {
        countdown.SetActive(true);
        ready.SetActive(true);
        go.SetActive(false);
        objectManager.SetActive(false);

        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(timer > 0)
        {
            yield return new WaitForSeconds(1f);

            timer--;
        }

        ready.SetActive(false);
        go.SetActive(true);

        yield return new WaitForSeconds(1f);

        countdown.SetActive(false);
        objectManager.SetActive(true);
    }
}
