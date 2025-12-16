using System.Collections;
using UnityEngine;

namespace Practice
{
    /// <summary>
    /// 이벤트를 게시하는 클래스 예저
    /// </summary>
    public class CountdownTimer : MonoBehaviour
    {
        public delegate void TimerStarted();

        public static event TimerStarted OnTimerStarted;

        public delegate void TimerEnded();

        public static event TimerEnded OnTimerEnded;
        [SerializeField] private float duration = 5.0f;

        private void Start()
        {
            StartCoroutine(StartCountdown());
        }

        private IEnumerator StartCountdown()
        {
            if (OnTimerStarted != null)
            {
                OnTimerStarted();
            }

            while (duration > 0)
            {
                yield return new WaitForSeconds(1f);
                duration--;
            }

            if (OnTimerEnded != null)
            {
                OnTimerEnded();
            }
        }

        private void OnGUI()
        {
            GUI.color = Color.blue;
            GUI.Label(new Rect(125, 0, 100, 20), "COUNTDOWN" + duration);
        }
    }
}