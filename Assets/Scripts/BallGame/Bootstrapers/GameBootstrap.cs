using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace BallGame
{
    public class GameBootstrap : MonoBehaviour
    {
        [SerializeField] private Ball _ballPrefab;
        [SerializeField] private int _ballCount;

        [SerializeField] private List<ColorScriptableObject> _colors;

        private BallsSpawner _ballsSpawner;
        private FinalCanvasMediator _finalCanvasMediator;
        private LevelLoadingData _levelLoadingData;
        private List<Ball> _balls;
        private GameFactory _gameFactory;

        private Level _level;
        private int _victoryCondition;

        public Level Level => _level;

        [Inject]
        private void Construct(BallsSpawner ballsSpawner, FinalCanvasMediator finalCanvasMediator, LevelLoadingData levelLoadingData)
        {
            _ballsSpawner = ballsSpawner;
            _finalCanvasMediator = finalCanvasMediator;
            _levelLoadingData = levelLoadingData;
        }

        private void Start()
        {
            CreateAndHideBalls();

            _level = new Level();

            _gameFactory = new GameFactory(_balls, _colors);

            _finalCanvasMediator.Initialize(this);

            StartGame(_levelLoadingData.GameMode);
        }
        
        public void ResetCurrentMode() => StartGame(_victoryCondition);

        public void SetScene(int scene) => SceneManager.LoadScene(scene);

        private void CreateAndHideBalls() => _balls = _ballsSpawner.SpawnBalls(_ballPrefab, _ballCount);

        private void StartGame(int gameMode)
        {
            _victoryCondition = gameMode;

            _level.Start(_gameFactory.GetGame(_victoryCondition));

            _finalCanvasMediator.LevelStarted();
        }
    }
}
