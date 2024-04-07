using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto : MonoBehaviour
{
    [SerializeField] TalkManager1 talkManager;
    [SerializeField] TalkBundel1[] bundles2;
    [SerializeField] TalkBundel1[] bundles5;
    [SerializeField] TalkBundel1[] bundles7;
    [SerializeField] TalkBundel1[] bundles9;
    [SerializeField] TalkBundel1[] bundles11;
    [SerializeField] TalkBundel1[] bundles13;
    [SerializeField] TalkBundel1[] bundles15;
    [SerializeField] TalkBundel1[] bundles17;
    [SerializeField] TalkBundel1[] bundles19;
    [SerializeField] TalkBundel1[] bundles20;
    [SerializeField] TalkBundel1[] bundles21;
    [SerializeField] TalkBundel1[] bundles23;
    [SerializeField] TalkBundel1[] bundles25;
    [SerializeField] TalkBundel1[] bundles27;
    [SerializeField] TalkBundel1[] bundles29;
    [SerializeField] TalkBundel1[] bundles31;
    [SerializeField] TalkBundel1[] bundles32;
    [SerializeField] TalkBundel1[] bundles34;
    [SerializeField] TalkBundel1[] bundles36;

    [SerializeField] Bringer bringerPrefab;
    [SerializeField] Cat catPrefab;

    Transform player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player = collision.gameObject.GetComponent<Transform>();

            switch (GameManager.Instance.StageNum)
            {
                case 0: //���̸�
                    if(GameManager.Instance.StageNum == 0)
                    {
                        talkManager.StartTalk(bundles2[0]);
                        player.transform.position = new Vector3(-36.1f, -39.5f, 0); //garden����
                        GameManager.Instance.StageNum = 1;  //garden����
                    }
                    break;
                case 1: //garden�̸�
                    talkManager.StartTalk(bundles5[0]);
                    player.transform.position = new Vector3(9.07f, -23.37f, 0); //1-1��
                    GameManager.Instance.StageNum = 2;  //1-1��
                    break;
                case 2: //1-1�̸�
                    if(GameManager.Instance.monsterCount == 5)
                    {
                        talkManager.StartTalk(bundles7[0]);
                        player.transform.position = new Vector3(58.7f, -23.6f, 0);  //1-2��
                        GameManager.Instance.StageNum = 3;  //1-2��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 3: //1-2��
                    if (GameManager.Instance.monsterCount == 5)
                    {
                        talkManager.StartTalk(bundles9[0]);
                        player.transform.position = new Vector3(111.6f, -23.3f, 0);  //1-3����
                        GameManager.Instance.StageNum = 4;  //1-3����
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 4: //1-3�̸�
                    if (GameManager.Instance.monsterCount == 5)
                    {
                        talkManager.StartTalk(bundles11[0]);
                        player.transform.position = new Vector3(165.2f, -23.6f, 0);  //1-4����
                        GameManager.Instance.StageNum = 5;  //1-4����
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 5: //1-4��
                    if (GameManager.Instance.monsterCount == 10)
                    {
                        talkManager.StartTalk(bundles13[0]);
                        player.transform.position = new Vector3(217.7f, -23.6f, 0);  //1-5��
                        GameManager.Instance.StageNum = 6;  //1-5��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 6: //1-5��
                    if (GameManager.Instance.monsterCount == 10)
                    {
                        talkManager.StartTalk(bundles15[0]);
                        player.transform.position = new Vector3(271.17f, -23.6f, 0);  //6-1��
                        GameManager.Instance.StageNum = 7;  //6-1��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 7: //6-1��
                    if (GameManager.Instance.monsterCount == 13)
                    {
                        talkManager.StartTalk(bundles17[0]);
                        player.transform.position = new Vector3(271.17f, 10.5f, 0);  //6-2��
                        Bringer bringer = Instantiate(bringerPrefab, new Vector2(271.17f, -7.5f), Quaternion.identity); //bringer����
                        GameManager.Instance.StageNum = 8;  //6-2��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 8: //6-2��
                    if (GameManager.Instance.monsterCount == 1 && GameManager.Instance.StageNum == 8)
                    {
                        talkManager.StartTalk(bundles19[0]);
                        player.transform.position = new Vector3(-37.86f, -0.51f, 0f); //�ι�° ������
                        GameManager.Instance.StageNum = 15;  //�ι�° ������
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 9: //2-1�̸�
                    if (GameManager.Instance.monsterCount == 8)
                    {
                        talkManager.StartTalk(bundles23[0]);
                        player.transform.position = new Vector3(58.9f, -65.7f, 0);  //2-2��
                        GameManager.Instance.StageNum = 10;  //2-2��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 10: //2-2��
                    if (GameManager.Instance.monsterCount == 12)
                    {
                        talkManager.StartTalk(bundles25[0]);
                        player.transform.position = new Vector3(111.8f, -65.7f, 0);  //2-3����
                        GameManager.Instance.StageNum = 11;  //2-3����
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 11: //2-3�̸�
                    if (GameManager.Instance.monsterCount == 11)
                    {
                        talkManager.StartTalk(bundles27[0]);
                        player.transform.position = new Vector3(166.41f, -65.7f, 0);  //2-4��
                        GameManager.Instance.StageNum = 12;  //2-4��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 12: //2-4�̸�
                    if (GameManager.Instance.monsterCount == 13)
                    {
                        talkManager.StartTalk(bundles29[0]);
                        player.transform.position = new Vector3(219.08f, -65.7f, 0);  //2-5��
                        GameManager.Instance.StageNum = 13;  //2-5��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 13: //2-5�̸�
                    if (GameManager.Instance.monsterCount == 12)
                    {
                        talkManager.StartTalk(bundles31[0]);
                        player.transform.position = new Vector3(-37.86f, -0.51f, 0f); //����° ������
                        GameManager.Instance.StageNum = 17;  //����° ������
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 14: //13-1�̸�
                    if (GameManager.Instance.monsterCount == 14)
                    {
                        talkManager.StartTalk(bundles34[0]);
                        player.transform.position = new Vector3(270.8f, -65.7f, 0);  //13-2��
                        Cat cat = Instantiate(catPrefab, new Vector2(270.86f, -53.82f), Quaternion.identity); //cat����
                        GameManager.Instance.StageNum = 18;  //13-2��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 15: //�ι�° ���̸�
                    talkManager.StartTalk(bundles20[0]);
                    player.transform.position = new Vector3(-36.1f, -39.5f, 0); //garden����
                    GameManager.Instance.StageNum = 16;
                    break;
                case 16: //�ι�° �����̸�
                    if(GameManager.Instance.StageNum == 16)
                    {
                        talkManager.StartTalk(bundles21[0]);
                        player.transform.position = new Vector3(8.94f, -65.7f, 0);  //2-1��
                        GameManager.Instance.StageNum = 9;  //2-1��
                        GameManager.Instance.monsterCount = 0;
                        ActivateSkills();
                        StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    }
                    break;
                case 17: //����° ���̸�
                    talkManager.StartTalk(bundles32[0]);
                    player.transform.position = new Vector3(270.8f, -65.7f, 0);  //13-1��
                    GameManager.Instance.StageNum = 14;  //13-1��
                    GameManager.Instance.monsterCount = 0;
                    ActivateSkills();
                    StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    break;
                case 18: //13-2��
                    talkManager.StartTalk(bundles36[0]);
                    player.transform.position = new Vector3(-37.86f, -0.51f, 0f); //�׹�° ������
                    GameManager.Instance.StageNum = 19;  //�׹�° ������
                    ActivateSkills();
                    StatusManager.Instance.hp += StatusManager.Instance.MaxHp * 0.1f;
                    break;

            }

        }
    }

    private void ActivateSkills()
    {
        if (PlayerMovement.Instance.level >= 2)
        {
            if(GameManager.Instance.ActiveSkillQ == false) 
            {
                PlayerMovement.Instance.moveSpeed = PlayerMovement.Instance.moveSpeed / 2;
                GameManager.Instance.ActiveSkillQ = true;
            }
            else
            {
                GameManager.Instance.ActiveSkillQ = true;
            }
        }

        if (PlayerMovement.Instance.level >= 4)
        {
            GameManager.Instance.ActiveSkillW = true;
        }

        if (PlayerMovement.Instance.level >= 6)
        {
            GameManager.Instance.ActiveSkillE = true;
        }

        if (PlayerMovement.Instance.level >= 8)
        {
            GameManager.Instance.ActiveSkillR = true;
        }
    }
}
