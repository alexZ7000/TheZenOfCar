using System;
using UnityEngine;

namespace DefaultNamespace.Effects.Star
{
    public class StarHighScore : MonoBehaviour
    {
        public StarCounter starCounter;
        public int highScore;

        public void Awake()
        {
            Load();
        }

        public void OnDestroy()
        {
            Save();
        }

        public void Save()
        {
            if (starCounter.starCount > highScore)
            {
                PlayerPrefs.SetInt("HighScore", starCounter.starCount);
            }
        }
        
        public string Load()
        {
            highScore = PlayerPrefs.GetInt("HighScore", 0);
            var highScore1 = highScore.ToString();
            return highScore1;
        }
    }
}