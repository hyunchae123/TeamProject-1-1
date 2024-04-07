using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// where T : ??  >  ���׸� Ÿ�� �ڷ������� ������ �д�.
public class Singleton<T> : MonoBehaviour
    where T : class
{
    // �������� �빮���� ������?
    // = ���� ������ �ҹ��������� �ش� ������ �б� �������� ������ ���
    //   ������ �̸��� ����ؾ��ϱ� ������ �̶��� �빮�ڷ� ����Ѵ�.
    public static T Instance { get; private set; }

    protected void Awake()
    {
        Instance = this as T;
    }
}
