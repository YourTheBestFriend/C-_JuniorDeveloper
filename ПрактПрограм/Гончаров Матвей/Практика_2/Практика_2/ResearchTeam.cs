using System;
using System.Collections; // System.Collections.ArrayList;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class ResearchTeam : Team
    {
        private string tema_inssled;
        private string name_organization;
        private int registr_num;
        private TimeFrame prodolzh_issled;
        //private Person[] list_person;
        private ArrayList listPerson= new ArrayList();
        //private Paper[] list_publicacii;
        private ArrayList listPublicacii = new ArrayList();
        //private object list_publicacii;

        // свойство типа System.Collections.ArrayList для доступа к полю со списком публикаций
        public ArrayList ListPublicacii
        {
            get => listPublicacii;
            set { listPublicacii = value; }
        }
        public Paper lastP
        {
            get
            {
                if (listPublicacii != null)
                {
                    return(Paper)this.listPublicacii[listPublicacii.Count - 1];
                }
                return null;
            } 
        }
        public ResearchTeam(string Name, int regNumber, string tema_inssled, string name_organization, int registr_num, TimeFrame prodolzh_issled, ArrayList list_person, ArrayList list_publicacii) : base(Name, regNumber)
        {
            this.tema_inssled = tema_inssled;
            this.name_organization = name_organization;
            this.registr_num = registr_num;
            this.prodolzh_issled = prodolzh_issled;
            this.listPerson = list_person;
            this.listPublicacii = list_publicacii;
        }

        public ResearchTeam() : base()
        {
            tema_inssled = "none";
            name_organization = "none";
            registr_num = 0;
            prodolzh_issled = 0;
        }

        // get
        public string Get_tema_inssled()
        {
            return tema_inssled;
        }
        public string Get_name_organization()
        {
            return name_organization;
        }
        public int Get_registr_num()
        {
            return registr_num;
        }
        public TimeFrame Get_prodolzh_issled()
        {
            return prodolzh_issled;
        }
        public ArrayList Get_list_list_person()
        {
            return this.listPerson;
        }
        public ArrayList Get_list_publicacii()
        {
            return this.listPublicacii;
        }
        //public ArrayList get_Paper_po_teme_issled
        //{
        //    get
        //    {
        //        int max = 0;
        //        for (int i = 0; i < Get_list_publicacii().Count; i++)
        //        {
        //            if (Get_list_publicacii() == null)
        //            {
        //                return null;
        //            }
        //            else
        //            {
        //                for (int j = 1; j < Get_list_publicacii().Count; j++)
        //                {
        //                    if (((ArrayList)Get_list_publicacii()[i].date_public.CompareTo((ArrayList)Get_list_publicacii()[j].date_public)) > 0)
        //                    {
        //                        max = i;
        //                    }
        //                }
        //            }
        //        }
        //        return (ArrayList)Get_list_publicacii()[max];
        //    }
        //}
        // индексатор будевского значение
        public bool this[TimeFrame x]
        {
            get
            {
                if (x == prodolzh_issled)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // set
        public void Set_tema_inssled(string tema_inssle)
        {
            this.tema_inssled = tema_inssle;
        }
        public void Set_name_organization(string name_organization)
        {
            this.name_organization = name_organization;
        }
        public void Set_registr_num(int registr_num)
        {
            this.registr_num = registr_num;
        }
        public void Set_prodolzh_issled(TimeFrame prodolzh_issled)
        {
            this.prodolzh_issled = prodolzh_issled;
        }

        // metods
        public void AddPapers(params Paper[] papers)
        {
            if (papers.Length == 0)
            {
                return;
            }
            int n = papers.Length;
            Array.Resize(ref papers, papers.Length + papers.Length);
            Array.Copy(papers, 0, papers, n, papers.Length);
        }

        public virtual object GetDeepCopy()
        {
            ResearchTeam obj1 = new ResearchTeam(this.Name, this.regNumber, this.tema_inssled, this.name_organization, this.registr_num, this.prodolzh_issled, this.listPerson, this.listPublicacii);
            return obj1;
        }

        public override string ToString()
        {
            return Get_tema_inssled() + " " + Get_name_organization() + " " + Get_registr_num();
        }

        public virtual string ToShortString()
        {
            return Get_tema_inssled() + " " + Get_name_organization() + " " + Get_registr_num() + " " + Get_prodolzh_issled();
        } 
    }
}
