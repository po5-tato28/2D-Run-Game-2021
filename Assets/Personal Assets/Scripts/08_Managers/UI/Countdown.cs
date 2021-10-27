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
        // countdown과 ready만 켜고 전부 끈다.
        countdown.SetActive(true);
        ready.SetActive(true);
        go.SetActive(false);
        objectManager.SetActive(false);

        // 코루틴 시작
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        // timer가 0초보다 많이 남았다면 1초씩 감소
        while(timer > 0)
        {
            yield return new WaitForSeconds(1f);

            timer--;
        }

        // timer가 0이 되면 ready는 끄고 go를 켠다.
        ready.SetActive(false);
        go.SetActive(true);

        // 그 후 1초를 기다리고
        yield return new WaitForSeconds(1f);

        // countdown 자체를 꺼버린다.
        countdown.SetActive(false);

        // 적 소환
        objectManager.SetActive(true);
    }
}
