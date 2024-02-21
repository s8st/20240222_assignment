using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private InputField inputField;
    // [SerializeField] private Text playerName;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;

    private  CharacterType characterType;

    public void OnClickCharacter()
    {
        information.SetActive(false);
        selectCharacter.SetActive(true);
    }

    // 클릭시 유니티에서 설정한 숫자가 (int index)로 넘겨짐
        public void OnClickSelectionCharacter(int index)
    {
        characterType = (CharacterType)index;
        // index  0 : penguin   1 : Knight

        var character = GameManager.Instance.CharacterList.Find(item => item.CharacterType == characterType);
        // item : 리스트에 있는 원소??
        // item은 펭귄과 나이트
        characterSprite.sprite = character.CharacterSprite; // 위에서 나온 이미지를 대입하라는 뜻인듯
        characterSprite.SetNativeSize(); // 크기 늘리기

        selectCharacter.SetActive(false); // 캘릭터 선택창은 닫기
        information.SetActive(true); // 정보창은 보이게


    }




    public void OnClickJoin()
    {
        // if(string.IsNullOrEmpty(inputField.text)) : 문자열에 문자가 있는지 확인
        // inputField.text : 사용자 입력한 값
        if (!( 2 < inputField.text.Length && inputField.text.Length < 10)) // 2 < text < 10
        {
            return;
        }


        //playerName.text = inputField.text;
        //GameManager.Instance.PlayerName.text = inputField.text;

        // OnClickSelectionCharacter() 에서
        //  저장 characterType = (CharacterType)index;
        GameManager.Instance.SetCharacter(characterType, inputField.text);
        Destroy(gameObject); // 이름 입력하고 join누르면  화면에서 ui삭제
    }
}
