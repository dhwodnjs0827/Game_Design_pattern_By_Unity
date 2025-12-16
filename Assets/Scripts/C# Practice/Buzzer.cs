using UnityEngine;

namespace Practice
{
    /// <summary>
    /// 게시자의 델리게이트에 특정 로컬 함수를 할당해 게시자 클래스가 트리거한 이벤트를 구독하는 클래스의 예제
    /// </summary>
    public class Buzzer : MonoBehaviour
    {
        private void OnEnable()
        {
            // 타이머 클래스에 선언한 델리게이트에 로컬 함수를 할당
            CountdownTimer.OnTimerStarted += PlayStartBuzzer;
            CountdownTimer.OnTimerEnded += PlayEndBuzzer;
        }

        private void OnDisable()
        {
            CountdownTimer.OnTimerStarted -= PlayStartBuzzer;
            CountdownTimer.OnTimerEnded -= PlayEndBuzzer;
        }

        private void PlayStartBuzzer()
        {
            Debug.Log("[BUZZER] : Play start buzzer!");
        }

        private void PlayEndBuzzer()
        {
            Debug.Log("[BUZZER] : Play end buzzer!");
        }
    }
}