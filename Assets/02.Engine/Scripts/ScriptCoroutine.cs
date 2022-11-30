using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Engine
{
	// MonoBehaviour
	// 모든 유니티 스크립트가 상속하는 기본 클래스
	// 컴포넌트, 이벤트, 코루틴의 기능을 포함하고 있음

	// 코루틴 : 스크립트의 Update 함수와 따로 돌아가는 비동기식으로 동작 (병렬처리는 아님)
	public class ScriptCoroutine : MonoBehaviour
	{
		private Coroutine coroutine;

		private void Start()
		{
			// StartCoroutine : 코루틴 시작
			coroutine = StartCoroutine(CoroutineFunc());

			// StopCoroutine : 코루틴 정지
			StopCoroutine(coroutine);

			// StopAllCoroutine : 스크립트가 추가한 모든 코루틴 정지
			StopAllCoroutines();
		}

		private IEnumerator CoroutineFunc()
		{
			Debug.Log(string.Format("{0} : 코루틴 시작", Time.time));
			yield return new WaitForSeconds(1f);    // 코루틴이 1초 동안 머뭄
			Debug.Log(string.Format("{0} : 코루틴 1초 확인", Time.time));
			yield return null;                      // 코루틴이 1프레임 동안 머뭄
			Debug.Log(string.Format("{0} : 코루틴 1프레임 확인", Time.time));

			int i = 0;
			while (true)
			{
				i++;
				yield return new WaitForSeconds(1f);
				Debug.Log(string.Format("{0} : 코루틴 진행중", Time.time));

				if (i > 3) yield break; // 코루틴 종료
			}
		}
	}
}