using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class scoreBoard : MonoBehaviour
{
    const string filename = "score.txt";
    private Text s1;
    private Text s2;
    private Text s3;
    private Text s4;
    private Text s5;
    private Text s6;
    private Text s7;
    private Text s8;
    private Text s9;
    private Text s10;
    Hashtable score;

    // Use this for initialization
    void Start()
    {
        loadElements();
        clearTable();
        score = loadScore();
        showScores();
    }


    void loadElements()
    {
        s1 = GameObject.Find("sc1").GetComponent<Text>();
        s2 = GameObject.Find("sc2").GetComponent<Text>();
        s3 = GameObject.Find("sc3").GetComponent<Text>();
        s4 = GameObject.Find("sc4").GetComponent<Text>();
        s5 = GameObject.Find("sc5").GetComponent<Text>();
        s6 = GameObject.Find("sc6").GetComponent<Text>();
        s7 = GameObject.Find("sc7").GetComponent<Text>();
        s8 = GameObject.Find("sc8").GetComponent<Text>();
        s9 = GameObject.Find("sc9").GetComponent<Text>();
        s10 = GameObject.Find("sc10").GetComponent<Text>();
    }

    void showScores()
    {
        List<Text> scores = new List<Text>();
        scores.Add(s1);
        scores.Add(s2);
        scores.Add(s3);
        scores.Add(s4);
        scores.Add(s5);
        scores.Add(s6);
        scores.Add(s7);
        scores.Add(s8);
        scores.Add(s9);
        scores.Add(s10);

        int iter = 0;

        foreach (DictionaryEntry entry in score)
        {
            string scset = entry.Key + ". " + entry.Value;
            Debug.Log("scset" + iter + ": " + scset);
            scores[iter].text = scset;
            iter=iter+1;

        }



    }

    void clearTable()
    {
        Debug.Log("Scoreboard clear");
        score = new Hashtable();
        for (int i = 0; i < 10; i++)
        {
            score.Add(i + 1, "jméno");
        }
    }

    Hashtable loadScore()
    {
        Debug.Log("Scoreboard load");
        Hashtable loaded = new Hashtable();
        string content = "";
        try
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(filename))
            {
                content = sr.ReadToEnd();
            }
        }
        catch (UnityException e)
        {
            Debug.Log("Chyba čtení souboru!");
        }
        content = content.Replace("\r\n", "");          //AltGr+Q
        ArrayList lines = new ArrayList(content.Split(';'));
        for (int i = 1; i < 11; i++)
        {
            ArrayList line = new ArrayList(lines[i - 1].ToString().Split(':'));
            Debug.Log("score " + i + " " + line[0].ToString() + " " + line[1].ToString());
            string add = (line[0].ToString() +" - "+line[1].ToString());
            Debug.Log("add" + i + ": " + add);
            loaded.Add(i, add);
        }
        return loaded;
    }

    void saveScore()
    {
        Debug.Log("Scoreboard save");
        System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
        foreach (DictionaryEntry entry in score)
        {
            file.WriteLine(entry.Key + ":" + entry.Value + ";");
        }
        file.Close();
    }

    void addScore(string name, int sc)
    {
        Debug.Log("Scoreboard add");
        int position = -1;
        foreach (DictionaryEntry d in score)
        {
            ArrayList line = new ArrayList(d.Value.ToString().Split(':'));
            if (int.Parse(line[1].ToString()) < sc)
            {
                position = int.Parse(d.Key.ToString());
                break;
            }
        }

        if (position > -1)
        {
            Hashtable newScores = new Hashtable();

            foreach (DictionaryEntry d in score)
            {
                if (int.Parse(d.Key.ToString()) < position)
                {
                    newScores.Add(d.Key, d.Value);
                }
                if (int.Parse(d.Key.ToString()) == position)
                {
                    newScores.Add(position, name + ":" + sc);
                }
                if (int.Parse(d.Key.ToString()) >= position)
                {
                    newScores.Add(int.Parse(d.Key.ToString()) + 1, d.Value);
                }
            }
            score = newScores;
            saveScore();
        }


    }
}
