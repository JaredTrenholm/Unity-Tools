using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    [System.Serializable]
    public struct Object
    {
        public GameObject objectPrefab;
        public int quantity;
    }
    public Object[] objectsToPool;
    private DebugLogging debug = new DebugLogging();

    private void Start()
    {
        debug.EnableDebug(true);
        PoolObjects();
    }
    public void PoolObjects()
    {
        foreach (Object gameObject in objectsToPool)
        {
            try
            {
                for (int i = 0; i < gameObject.quantity; i++)
                {
                    GameObject spawnedObject = GameObject.Instantiate(gameObject.objectPrefab);
                    spawnedObject.SetActive(false);
                    spawnedObject.transform.SetParent(this.gameObject.transform);
                }
            }
            catch
            {
                debug.Log("Something errored when pooling " + gameObject.objectPrefab + " x" + gameObject.quantity);
            }
        }
    }
}
