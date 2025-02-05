﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPool : MonoBehaviour
{
    public Dictionary<int, Pool> pools = new Dictionary<int, Pool>();

    public Pool AddPool(PoolType id, bool reparent = true)
    {
        Pool pool;

        if (pools.TryGetValue((int)id, out pool) == false)
        {
            pool = new Pool();
            pools.Add((int)id, pool);

            if (reparent)
            {
                var poolsGO = GameObject.Find("[POOLS]") ?? new GameObject("[POOLS]");
                var poolGO = new GameObject("Pool:" + id);
                poolGO.transform.SetParent(poolsGO.transform);
                pool.SetParent(poolGO.transform);
            }
        }

        return pool;
    }

    public GameObject Spawn(PoolType id, GameObject prefab, Vector3 position = default(Vector3),
            Quaternion rotation = default(Quaternion),
            Transform parent = null)
    {
        return pools[(int)id].Spawn(prefab, position, rotation, parent);
    }

    public T Spawn<T>(PoolType id, GameObject prefab, Vector3 position = default(Vector3),
        Quaternion rotation = default(Quaternion),
        Transform parent = null) where T : class
    {
        var val = pools[(int)id].Spawn(prefab, position, rotation, parent);
        return val.GetComponent<T>();
    }

    public void Despawn(PoolType id, GameObject obj)
    {
        pools[(int)id].Despawn(obj);
    }

    public void Dispose()
    {
        foreach (var poolsValue in pools.Values)
            poolsValue.Dispose();
        pools.Clear();
    }
}
