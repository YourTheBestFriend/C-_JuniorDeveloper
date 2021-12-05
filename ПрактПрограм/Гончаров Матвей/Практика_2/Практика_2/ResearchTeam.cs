using System;
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
        private Paper[] list_publicacii;
        public ResearchTeam(string tema_inssle, string name_organization, int registr_num, TimeFrame prodolzh_issled, Paper[] list_publicacii)
        {
            this.tema_inssled = tema_inssle;
            this.name_organization = name_organization;
            this.registr_num = registr_num;
            this.prodolzh_issled = prodolzh_issled;
            this.list_publicacii = list_publicacii;
        }

        public ResearchTeam() 
        {
            tema_inssled = "none";
            name_organization = "none";
            registr_num = 0;
            prodolzh_issled = 0;
            list_publicacii = new Paper[0];
        }

        // get
        public string get_tema_inssled()
        {
            return tema_inssled;
        }
        public string get_name_organization()
        {
            return name_organization;
        }
        public int get_registr_num()
        {
            return registr_num;
        }
        public TimeFrame get_prodolzh_issled()
        {
            return prodolzh_issled;
        }
        public Paper[] get_list_publicacii()
        {
            return list_publicacii;
        }
        public Paper get_Paper_po_teme_issled
        {
            get
            {
                int max = 0;
                for (int i = 0; i < get_list_publicacii().Length; i++)
                {
                    if (get_list_publicacii() == null)
                    {
                        return null;
                    }
                    else
                    {
                        for (int j = 1; j < get_list_publicacii().Length; j++)
                        {
                            if ((get_list_publicacii()[i].date_public.CompareTo(get_list_publicacii()[j].date_public)) > 0)
                            {
                                max = i;
                            }
                        }
                    }
                }
                return get_list_publicacii()[max];
            }
        }
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
        public void set_tema_inssled(string tema_inssle)
        {
            this.tema_inssled = tema_inssle;
        }
        public void set_name_organization(string name_organization)
        {
            this.name_organization = name_organization;
        }
        public void set_registr_num(int registr_num)
        {
            this.registr_num = registr_num;
        }
        public void set_prodolzh_issled(TimeFrame prodolzh_issled)
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
        public override string ToString()
        {
            return get_tema_inssled() + " " + get_name_organization() + " " + get_registr_num();
        }

        public virtual string ToShortString()
        {
            return get_tema_inssled() + " " + get_name_organization() + " " + get_registr_num() + " " + get_prodolzh_issled();
        } 
    }
}
