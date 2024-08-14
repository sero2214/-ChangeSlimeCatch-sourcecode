using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    [SerializeField] Score SC;

    // 触れたアイテムとスライムの属性が合致しているかどうかを判定。
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string playertag = this.gameObject.tag;

        if (collision.gameObject.CompareTag(playertag))
        {
            SC.Hitjudgement(true, true);
        }

        else if (!collision.gameObject.CompareTag(playertag))
        {

            switch (collision.gameObject.tag)
            {
                case "Blue":
                    if (playertag == "Green")
                    {
                        SC.Hitjudgement(true);
                    }

                    else
                    {
                        SC.Hitjudgement(false);
                    }
                    break;

                case "Red":
                    if (playertag == "Blue")
                    {
                        SC.Hitjudgement(true);
                    }

                    else
                    {
                        SC.Hitjudgement(false);
                    }
                    break;

                case "Green":
                    if (playertag == "Red")
                    {
                        SC.Hitjudgement(true);
                    }

                    else
                    {
                        SC.Hitjudgement(false);
                    }
                    break;

            }

        }

    }
}
