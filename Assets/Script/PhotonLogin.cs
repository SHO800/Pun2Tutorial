using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

//MonoBehaviourPunCallbacksを継承することでPUNのコールバックを受け取れるようにするらしい
public class PhotonLogin : MonoBehaviourPunCallbacks{

    public Camera mainCamera;

    private void Start(){
        //プレイヤー名を"Player"に設定する
        PhotonNetwork.NickName = "Player";
        //PhotonServerSettingsの設定内容でマスターサーバーへ接続
        PhotonNetwork.ConnectUsingSettings();
    }

    //マスターサーバーへの接続が成功したときに呼び出されるコールバック
    public override void OnConnectedToMaster(){
        //"Room"という名前のルームに参加するらしい(ルームが存在しなければ作成して参加してくれる)
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    //ルームへの接続に成功したときに呼ばれるコールバック
    public override void OnJoinedRoom() {
        //ランダムな座標に自身のアバター(ネットワークオブジェクトというそう)を生成する
        var position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        //おそらく"Avatar"の部分が自身のアバターのプレハブ、positionは配列みたい?
        GameObject avatar = PhotonNetwork.Instantiate("Avatar", position, Quaternion.identity);

        mainCamera.transform.parent = avatar.transform;
        mainCamera.transform.localPosition = new Vector3(0f,0f,-10f);
    }
}