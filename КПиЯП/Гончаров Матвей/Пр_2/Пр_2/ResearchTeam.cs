using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class ResearchTeam : Team, INameAndCopy
    {
        string researchTopic;
        TimeFrame researchDuration;
        ArrayList cardList;
        ArrayList humList;
        public string name { get; set; }


        public ResearchTeam()
        {
            researchTopic = "None";
            researchDuration = TimeFrame.Year;
        }
        public ResearchTeam(string researchTopic, TimeFrame researchDuration)
        {
            this.researchTopic = researchTopic;
            this.researchDuration = researchDuration;
            cardList = new ArrayList { };
            humList = new ArrayList { };
        }

        public string ResearchTopic
        {
            get { return researchTopic; }
            set { researchTopic = value; }
        }
        public TimeFrame ResearchDuration
        {
            get { return researchDuration; }
            set { researchDuration = value; }
        }
        public ArrayList CardList
        {
            get { return cardList; }
            set { cardList = value; }
        }
        public ArrayList HumList
        {
            get { return humList; }
            set { humList = value; }
        }
           
        public Team Team
        {
            get
            {
                return new Team(CompName,RegistrNum);
            }
            set
            {
                CompName = value.CompName;
                RegistrNum = value.RegistrNum;
            }
        }

        public Paper Paper
        {
            get
            {
                int max = 0;
                for (int i = 0; i < cardList.Count - 1; i++)
                {
                    if (cardList.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        for (int j = 1; j < cardList.Count; j++)
                        {
                            if ((cardList[i] as Paper).cardDate.CompareTo((cardList[j] as Paper).cardDate) > 0)
                            {
                                max = i;
                            }
                        }
                    }
                }
                return (Paper)cardList[max];
            }
        }

        public bool this[TimeFrame n]
        {
            get
            {
                if (n == researchDuration)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void AddPapers(params Paper[] cardList1)
        {
            if (cardList1.Length == 0)
            {
                return;
            }
            for (int i = 0; i < cardList1.Length; i++)
            {
                cardList.Add(cardList1[i]);
            }
        }

        public void AddMembers(params Personn[] humList1)
        {
            if (humList1.Length == 0)
            {
                return;
            }
            for (int i = 0; i < humList1.Length; i++)
            {
                humList.Add(humList1[i]);
            }

        }

        public string ShowPaper()
        {
            string s = string.Empty;
            for (int i = 0; i < cardList.Count; i++)
            {
                s += "\n" + (cardList[i] as Paper).ToString();
            }
            return s;
        }
        public string ShowPerson()
        {
            string s = string.Empty;
            for (int i = 0; i < humList.Count; i++)
            {
                s += "\n" + (humList[i] as Personn).ToString();
            }
            return s;
        }
        public override string ToString() => $"Тема исследования: {researchTopic}\nПродолжительность исследований: {researchDuration}\nСписок публикаций: {ShowPaper()}\nСписок участников: {ShowPerson()}";
        public virtual string ToShortString() => $"Тема исследования: {researchTopic}\nПродолжительность исследований: {researchDuration}";

        public new object DeepCopy()
        {
            ResearchTeam other = (ResearchTeam)this.MemberwiseClone();
            other.cardList = new ArrayList { };
            for (int i = 0; i < cardList.Count; i++)
            {
                other.cardList = cardList;
            }
            other.humList = new ArrayList { };
            for (int i = 0; i < humList.Count; i++)
            {
                other.humList = humList;
            }
            return other;
        }

        public IEnumerable<Personn> PerWithoutPub()
        {
            for (int i = 0; i < humList.Count; i++)
            {
                int k = 0;
                for (int j = 0; j < cardList.Count; j++)
                {
                    if ((cardList[j] as Paper).cardAuthor.Name == (humList[i] as Personn).Name)
                    {
                        k++;
                    }
                }
                if(k==0)
                {
                    yield return (Personn)humList[i];
                }
            }
        }

        public IEnumerable<Paper> LastPaper(int n)
        {
            for (int i = 0; i < cardList.Count; i++)
            {
                if (((Paper)cardList[i]).cardDate.Year >= DateTime.Now.Year - n)
                {
                    yield return (Paper)cardList[i];
                }
            }
        }

        public IEnumerable<Personn> PerWithMoreOnePub()
        {
            ArrayList PerWithoutP = new ArrayList();
            int f;
            foreach (Personn item in humList)
            {
                f = 0;
                foreach (Paper i in cardList)
                {
                    if (i.cardAuthor == item)
                        f++;
                }
                if (f>1)
                    PerWithoutP.Add(item);
            }
            for (int i = 0; i < PerWithoutP.Count; i++)
            {
                yield return (Personn)PerWithoutP[i];
            }
        }

        public IEnumerable<Paper> LastYearPaper()
        {
            for (int i = 0; i < cardList.Count; i++)
            {
                if (((Paper)cardList[i]).cardDate.Year == DateTime.Now.Year)
                {
                    yield return (Paper)cardList[i];
                }
            }
        }

    }
}
