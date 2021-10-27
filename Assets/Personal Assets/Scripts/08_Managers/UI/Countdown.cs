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
        // countdown�� ready�� �Ѱ� ���� ����.
        countdown.SetActive(true);
        ready.SetActive(true);
        go.SetActive(false);
        objectManager.SetActive(false);

        // �ڷ�ƾ ����
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        // timer�� 0�ʺ��� ���� ���Ҵٸ� 1�ʾ� ����
        while(timer > 0)
        {
            yield return new WaitForSeconds(1f);

            timer--;
        }

        // timer�� 0�� �Ǹ� ready�� ���� go�� �Ҵ�.
        ready.SetActive(false);
        go.SetActive(true);

        // �� �� 1�ʸ� ��ٸ���
        yield return new WaitForSeconds(1f);

        // countdown ��ü�� ��������.
        countdown.SetActive(false);

        // �� ��ȯ
        objectManager.SetActive(true);
    }
}
