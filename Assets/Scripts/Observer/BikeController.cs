using System;
using UnityEngine;

namespace Observer
{
    public class BikeController : Subject
    {
        public bool IsTurboOn { get; private set; }

        public float CurrentHealth => health;

        private bool isEngineOn;
        private HUDController hudController;
        private CameraController cameraController;

        [SerializeField] private float health = 100.0f;

        [Obsolete("FindObjectOfType 호출로 인해 추후 변경해야 함.")]
        private void Awake()
        {
            hudController = gameObject.AddComponent<HUDController>();
            cameraController = (CameraController)FindObjectOfType(typeof(CameraController));
        }

        private void Start()
        {
            StartEngine();
        }

        private void OnEnable()
        {
            if (hudController)
            {
                Attach(hudController);
            }

            if (cameraController)
            {
                Attach(cameraController);
            }
        }

        private void OnDisable()
        {
            if (hudController)
            {
                Detach(hudController);
            }

            if (cameraController)
            {
                Detach(cameraController);
            }
        }

        private void StartEngine()
        {
            isEngineOn = true;
            NotifyObservers();
        }

        public void ToggleTurboOn()
        {
            if (isEngineOn)
            {
                IsTurboOn = !IsTurboOn;
            }
            NotifyObservers();
        }

        public void TakeDamage(float amount)
        {
            health -= amount;
            IsTurboOn = false;
            
            NotifyObservers();

            if (health < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}