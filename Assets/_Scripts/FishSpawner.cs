using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] private Fish fishPrefabs;

    [SerializeField] private Fish.FishType[] fishTypes;

    private void Awake()
    {
        SpawnFish();
    }

    private void SpawnFish()
    {
        for(int i = 0; i < fishTypes.Length; i++)
        {
            int num = 0;
            while(num < fishTypes[i].fishCount)
            {
                Fish fish = Instantiate<Fish>(fishPrefabs);
                fish.Type = fishTypes[i];
                fish.ResetFish();
                num++;
            }
        }
    }
}
