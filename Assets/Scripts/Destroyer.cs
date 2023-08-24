using UnityEngine;

namespace DefaultNamespace
{
    public class Destroyer : MonoBehaviour
    {
        public float timer;
        
        private void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}