using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CommandPattern
{
    public class Invoker : MonoBehaviour
    {
        private bool isRecording;
        private bool isReplaying;
        private float replayTime;
        private float recordingTime;
        private SortedList<float, Command> recordCommands = new SortedList<float, Command>();

        public void ExecuteCommand(Command command)
        {
            command.Execute();

            if (isRecording)
            {
                recordCommands.Add(recordingTime, command);
            }

            Debug.Log("Recorded Time: " + recordingTime);
            Debug.Log("Recorded Command: " + command);
        }

        public void Record()
        {
            recordingTime = 0.0f;
            isRecording = true;
        }

        public void Replay()
        {
            replayTime = 0.0f;
            isReplaying = true;

            if (recordCommands.Count <= 0)
            {
                Debug.LogError("No commands to replay!");
            }

            recordCommands.Reverse();
        }

        private void FixedUpdate()
        {
            if (isRecording)
            {
                recordingTime += Time.fixedDeltaTime;
            }

            if (isReplaying)
            {
                replayTime += Time.fixedDeltaTime;

                if (recordCommands.Any())
                {
                    if (Mathf.Approximately(replayTime, recordCommands.Keys[0]))
                    {
                        Debug.Log("Replay Time: " + replayTime);
                        Debug.Log("Replay Command: " + recordCommands.Values[0]);

                        recordCommands.Values[0].Execute();
                        recordCommands.RemoveAt(0);
                    }
                }
                else
                {
                    isReplaying = false;
                }
            }
        }
    }
}