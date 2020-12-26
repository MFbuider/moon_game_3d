﻿using UnityEngine;
using UnityEngine.UI;

public class HeroPlayer : Hero
{
    // 四顆招式按鈕
    public Button skill1;
    public Button skill2;
    public Button skill3;
    public Button skill4;

    private Image[] imgSkills = new Image[4];
    private Text[] textSkills = new Text[4];

    // override 複寫 - 可以複寫父類別包含 virtual 的成員
    protected override void Awake()
    {
        base.Awake();

        setbutton();
    }
    private void setbutton()
    {
        skill1 = GameObject.Find("技能(1)").GetComponent<Button>();
        skill2 = GameObject.Find("技能(2)").GetComponent<Button>();
        skill3 = GameObject.Find("技能(3)").GetComponent<Button>();
        skill4 = GameObject.Find("大絕").GetComponent<Button>();

        skill1.onClick.AddListener(Skill1);
        skill2.onClick.AddListener(Skill2);
        skill3.onClick.AddListener(Skill3);
        skill4.onClick.AddListener(Skill4);
        for (int i = 0; i < 4; i++)
        {
            imgSkills[i] = GameObject.Find("技能圖片 " + (i + 1)).GetComponent<Image>();
            textSkills[i] = GameObject.Find("技能冷卻 " + (i + 1)).GetComponent<Text>();
            // 更新技能圖片與冷卻時間
            imgSkills[i].sprite = data.skills[i].image;
            textSkills[i].text = "";
        }
    }
}
