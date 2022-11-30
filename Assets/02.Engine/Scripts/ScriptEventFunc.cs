using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine
{
	// MonoBehaviour
	// 모든 유니티 스크립트가 상속하는 기본 클래스
	// 컴포넌트, 이벤트, 코루틴의 기능을 포함하고 있음

	// 이벤트 : 스크립트가 씬에 포함되어 있는 경우 유니티 메시지에 반응하는 함수
	public class ScriptEventFunc : MonoBehaviour
	{
		private void Awake()
		{
			// 스크립트가 씬에 포함되었을 때 1회 호출되는 함수
			// 스크립트를 가지고 있는 게임오브젝트가 초기화 되었을 때 호출됨
			// 스크립트가 비활성화 되어 있는 경우에도 호출됨

			// 역할 : 변수 또는 상태를 초기화 작업 진행
			Debug.Log("Awake");
		}

		private void OnEnable()
		{
			// 스크립트가 활성화될 때마다 호출

			// 역할 : 스크립트가 활성화 되었을 때 작업 진행
			Debug.Log("OnEnable");
		}

		private void Start()
		{
			// 스크립트가 씬에 처음으로 Update하기 직전에 1회 호출됨
			// 스크립트가 비활성화된 경우 호출되지 않음

			// 역할 : 1. Awake에서 초기화된 결과가 필요한 초기화 작업들 진행
			//		  2. 코루틴 시작
			Debug.Log("Start");
		}

		private void Update()
		{
			// 게임의 프레임마다 호출

			// 역할 : 핵심 게임 로직 구현
			Debug.Log("Update");
		}

		private void LateUpdate()
		{
			// 씬의 모든 게임오브젝트의 Update가 진행된 후 호출

			// 역할 : 게임프레임의 진행 결과가 필요한 동작이 있는 기능 구현
			// ex) 플레이어의 위치가 결정된 후에 카메라의 위치 설정
			Debug.Log("LateUpdate");
		}

		private void FixedUpdate()
		{
			// 유니티의 물리설정 단위시간마다 호출 (기본 1초에 50번)
			// Update와 다르게 프레임당 연산과 단위시간이 일정

			// 역할 : 지연시간이 있어도 영향을 받아서는 안되는 작업
			Debug.Log("FixedUpdate");
		}

		private void OnDisable()
		{
			// 스크립트가 비활성화될 때마다 호출

			// 역할 : 스크립트가 비활성화 되었을 때 작업 진행
			Debug.Log("OnDisable");
		}

		private void OnDestroy()
		{
			// 스크립트가 삭제되었을 경우 호출

			// 역할 : 스크립트의 마무리 진행
			Debug.Log("OnDestory");
		}
	}
}
