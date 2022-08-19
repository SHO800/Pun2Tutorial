using Photon.Pun;
using TMPro;

//MonoBehaviourPunCallbackを継承してphotonViewプロパティを使えるようにする
public class AvatarNameDisplay : MonoBehaviourPunCallbacks{
    private void Start(){
        var nameLabel = GetComponent<TextMeshPro>();
        //プレイヤー名とプレイヤーID(ルーム内IDを表すプレイヤー名末尾のカッコの数字)を表示する
        nameLabel.text = $"{photonView.Owner.NickName}({photonView.OwnerActorNr})";

    }
}