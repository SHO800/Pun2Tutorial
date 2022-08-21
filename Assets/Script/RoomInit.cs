using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomInit : MonoBehaviourPunCallbacks
{
    public string[] placeBuildingsName;
    public Vector2[] buildingsPosition;

    //外部から関数を呼び出して使用
    public void BuildingsPlacement()
    {
        //参考 https://futabazemi.net/unity/shuffle_set_object
        //このtempは一度placeBuildingsNameの要素(つまり出現させる建物のプレハブの名前)を一度すべて入れ、そこからランダムに取り出して消していくという形で使う
        List<string> temp = new List<string>();

        foreach(string building in placeBuildingsName)
        {
            temp.Add(building);
        }

        foreach(Vector2 position in buildingsPosition)
        {
            int random = Random.Range(0,temp.Count);
            PhotonNetwork.InstantiateRoomObject(temp[random], position, Quaternion.identity);
            temp.RemoveAt(random);
        }
    }
}
