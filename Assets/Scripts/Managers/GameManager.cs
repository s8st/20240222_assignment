using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
    Penguin,
    Knight
}

[System.Serializable] // Ŭ������ public�Ǿ�� ����ȭ�� �ؾ� �ν����Ϳ� ���δ�
public class Character
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    // public Animator AnimatorController;
    public RuntimeAnimatorController AnimatorController;
    // Animator : player�� �޸� ������Ʈ �� �ϳ��� Animator
    // RuntimeAnimatorController : project - Assets - Animations �ȿ� �ִ� Animator
}




public class GameManager : MonoBehaviour
{
  public static GameManager Instance;

    public List<Character> CharacterList = new List<Character>(); // ����ϰ� ���

    public Animator PlayerAnimator; // ���ϸ�������Ʈ�ѷ��� �ֱ� ����???
    public Text PlayerName;

    private void Awake()
    {
        // Instance�� ������ �����ǰ� ��������� ���� ����
        if (Instance == null) // Instance�� ����ٸ�
        Instance = this; //this�� GameManager. Instance = GameManager

        else // Instance�� ������̶�� ���� gameObject(=GameManager)�� �ı�
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject); // ���ӿ�����Ʈ�� �����ϱ� ����

    }


    public void SetCharacter(CharacterType characterType, string name)
    {
        // �÷��̾� ���� �������� (0,1) ���, ���
        var character = GameManager.Instance.CharacterList.Find(item => item.CharacterType == characterType);

        // �ش��ϴ� ��Ÿ����Ʈ�ѷ��� ĳ������ ���ϸ����� ��Ʈ�ѷ�??
        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        PlayerName.text = name;
    }
}
