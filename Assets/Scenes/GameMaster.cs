using System.Collections;
using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class GameMaster : MonoBehaviour
    {
        #region VARIABLES

        [Header("General Settings")]
        public Vector2 Bounds = new Vector2(3f, 3f);
        public float BallSpeed = 3f;

        private WaitForSeconds waitForSecond;
        private WaitForSeconds waitRoundStartDelay;

        #endregion VARIABLES

        #region PROPERTIES

        public static GameMaster Instance
        {
            get;
            private set;
        }

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Awake()
        {
            if(Instance != null)
            {
                Destroy(gameObject);
            }

            Instance = this;

            waitForSecond = new WaitForSeconds(1);
            waitRoundStartDelay = new WaitForSeconds(2);
        }

        private void Start()
        {
            StartRound();
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        public void StartRound()
        {
            StartCoroutine(IStartRound());
        }

        private IEnumerator IStartRound()
        {
            yield return waitRoundStartDelay;

            for(int i = 3; i > 0; i--)
            {
                Debug.Log(i);

                yield return waitForSecond;
            }

            Debug.Log("GO!");

            SpawnBall();
        }

        private void SpawnBall()
        {

        }

        #endregion CUSTOM_FUNCTIONS
    }
}

