using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Engine
{
	// MonoBehaviour
	// ��� ����Ƽ ��ũ��Ʈ�� ����ϴ� �⺻ Ŭ����
	// ������Ʈ, �̺�Ʈ, �ڷ�ƾ�� ����� �����ϰ� ����

	// �ڷ�ƾ : ��ũ��Ʈ�� Update �Լ��� ���� ���ư��� �񵿱������ ���� (����ó���� �ƴ�)
	public class ScriptCoroutine : MonoBehaviour
	{
		private Coroutine coroutine;

		private void Start()
		{
			// StartCoroutine : �ڷ�ƾ ����
			coroutine = StartCoroutine(CoroutineFunc());

			// StopCoroutine : �ڷ�ƾ ����
			StopCoroutine(coroutine);

			// StopAllCoroutine : ��ũ��Ʈ�� �߰��� ��� �ڷ�ƾ ����
			StopAllCoroutines();
		}

		private IEnumerator CoroutineFunc()
		{
			Debug.Log(string.Format("{0} : �ڷ�ƾ ����", Time.time));
			yield return new WaitForSeconds(1f);    // �ڷ�ƾ�� 1�� ���� �ӹ�
			Debug.Log(string.Format("{0} : �ڷ�ƾ 1�� Ȯ��", Time.time));
			yield return null;                      // �ڷ�ƾ�� 1������ ���� �ӹ�
			Debug.Log(string.Format("{0} : �ڷ�ƾ 1������ Ȯ��", Time.time));

			int i = 0;
			while (true)
			{
				i++;
				yield return new WaitForSeconds(1f);
				Debug.Log(string.Format("{0} : �ڷ�ƾ ������", Time.time));

				if (i > 3) yield break; // �ڷ�ƾ ����
			}
		}
	}
}