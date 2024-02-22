using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
    Penguin,
    Knight
}

[System.Serializable] // 클래스는 public되었어도 직렬화를 해야 인스펙터에 보인다
public class Character
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    // public Animator AnimatorController;
    public RuntimeAnimatorController AnimatorController;
    // Animator : player에 달린 컴포넌트 중 하나인 Animator
    // RuntimeAnimatorController : project - Assets - Animations 안에 있는 Animator
}




public class GameManager : MonoBehaviour
{
  public static GameManager Instance;

    public List<Character> CharacterList = new List<Character>(); // 펭귄하고 기사

    public Animator PlayerAnimator; // 에니메이터컨트롤러에 넣기 위해???
    public Text PlayerName;

    private void Awake()
    {
        // Instance가 여러개 생성되고 덮어쓰여지는 것을 방지
        if (Instance == null) // Instance가 비었다면
        Instance = this; //this는 GameManager. Instance = GameManager

        else // Instance가 사용중이라면 지금 gameObject(=GameManager)를 파괴
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject); // 게임오브젝트를 유지하기 위해

    }


    public void SetCharacter(CharacterType characterType, string name)
    {
        // 플레이어 정보 가져오기 (0,1) 펭귄, 기사
        var character = GameManager.Instance.CharacterList.Find(item => item.CharacterType == characterType);

        // 해당하는 런타임컨트롤러에 캐릭터의 에니메이터 컨트롤러??
        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        PlayerName.text = name;
    }
}
