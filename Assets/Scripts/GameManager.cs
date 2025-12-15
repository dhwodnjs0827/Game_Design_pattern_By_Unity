using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime sessionStartTime;
    private DateTime sessionEndTime;

    private void Start()
    {
        //TODO:
        // - 플레이어 세이브 로드
        // - 세이브가 없으면 플레이어를 등록 씬으로 리다이렉션한다.
        // - 백엔드를 호출하고 일일 챌린지와 보상을 얻는다.
        
        sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @: " + DateTime.Now);
    }

    private void OnApplicationQuit()
    {
        sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = sessionEndTime.Subtract(sessionStartTime);
        
        Debug.Log("Game session end @: " + DateTime.Now);
        Debug.Log("Game session lasted: " + timeDifference);
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
