using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Practice
{
    /// <summary>
    /// 전역에서 접근할 수 있는 이벤트 버스를 설정하고자 static 키워드를 사용하는 클래스
    /// </summary>
    public class RaceEventBus : MonoBehaviour
    {
        private static readonly IDictionary<RaceEventType, UnityEvent> Events =
            new Dictionary<RaceEventType, UnityEvent>();

        public static void Subscribe(RaceEventType eventType, UnityAction listener)
        {
            if (Events.TryGetValue(eventType, out var thisEvent))
            {
                thisEvent.AddListener(listener);
            }
            else
            {
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Events.Add(eventType, thisEvent);
            }
        }

        public static void Unsubscribe(RaceEventType eventType, UnityAction listener)
        {
            if (Events.TryGetValue(eventType, out var thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }

        public static void Publish(RaceEventType eventType, UnityEvent unityEvent)
        {
            if (Events.TryGetValue(eventType, out var thisEvent))
            {
                thisEvent.Invoke();
            }
        }
    }

    public enum RaceEventType
    {
    }
}