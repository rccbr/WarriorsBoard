using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Warriors;
using WarriorsBoard.Warriors.AnimationStates;


namespace WarriorsBoard.Manager
{
    public enum GameplayState
    {
        Translate,
        Attack,
        Stop
    };
    
    public enum GameStatus
    {
        Playing,
        Finished
    };

    public class GameplayManager : MonoBehaviour
    {
        private static GameplayManager gameplayManager;

        public GameplayState gamePlayState;

        public GameStatus gameStatus;

        public delegate void GameStart();
        public static event GameStart OnGameStart;

        public Warrior[] warriors; 


        public static GameplayManager getInstance()
        {
            return gameplayManager;
        }

        void Awake()
        {
            gameplayManager = this;
        }

        // Use this for initialization

        void Start()
        {
            SwordsManAnimationStates.getInstance().NoTranslation();

            Go();
        }

        // Update is called once per frame

        void Update()
        {
            // Events are fired when the game begins

            if (OnGameStart != null)
                OnGameStart();
        }

        public void Go()
        {
            Invoke("GameBegins", 3.0f);
        }

        void GameBegins()
        {
            SwordsManAnimationStates.getInstance().Translate();

            SwordsMan.getInstance().enableTranslation = true;

            SwordsMan.getInstance().RotateTowards(SwordsMan.getInstance().nextDestination);

            gameStatus = GameStatus.Playing;
        }
    }
}


