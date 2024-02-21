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

    // Ŭ���� ����Ƽ���� ������ ���ڰ� (int index)�� �Ѱ���
        public void OnClickSelectionCharacter(int index)
    {
        characterType = (CharacterType)index;
        // index  0 : penguin   1 : Knight

        var character = GameManager.Instance.CharacterList.Find(item => item.CharacterType == characterType);
        // item : ����Ʈ�� �ִ� ����??
        // item�� ��ϰ� ����Ʈ
        characterSprite.sprite = character.CharacterSprite; // ������ ���� �̹����� �����϶�� ���ε�
        characterSprite.SetNativeSize(); // ũ�� �ø���

        selectCharacter.SetActive(false); // Ķ���� ����â�� �ݱ�
        information.SetActive(true); // ����â�� ���̰�


    }




    public void OnClickJoin()
    {
        // if(string.IsNullOrEmpty(inputField.text)) : ���ڿ��� ���ڰ� �ִ��� Ȯ��
        // inputField.text : ����� �Է��� ��
        if (!( 2 < inputField.text.Length && inputField.text.Length < 10)) // 2 < text < 10
        {
            return;
        }


        //playerName.text = inputField.text;
        //GameManager.Instance.PlayerName.text = inputField.text;

        // OnClickSelectionCharacter() ����
        //  ���� characterType = (CharacterType)index;
        GameManager.Instance.SetCharacter(characterType, inputField.text);
        Destroy(gameObject); // �̸� �Է��ϰ� join������  ȭ�鿡�� ui����
    }
}
