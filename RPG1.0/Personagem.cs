using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG1._0
{
    public class Personagem
    {
        private int I_COD_FICHA=-1;
        private string S_PER_FICHA;
        private string S_CLAS_FICHA;
        private int I_VIG_FICHA;
        private int I_AGIL_FICHA;       
        private int I_FOR_FICHA;       
        private int I_VEL_FICHA;     
        private int I_PERC_FICHA;        
        private string S_TAM_FICHA;    
        private int I_CAR_FICHA;
        private int I_FORV_FICHA;
        private int I_INTE_FICHA;
        private int I_XP_FICHA;
        private string S_DEF_FICHA;
        private string S_APT_FICHA;
        private string S_ANT_FICHA;

        public int Cod_Ficha
        {
            get => I_COD_FICHA;
            set => I_COD_FICHA = value;
        }
        public string Per_Ficha
        {
            get => S_PER_FICHA;
            set => S_PER_FICHA = value;
        }
        public string Clas_Ficha
        {
            get => S_CLAS_FICHA;
            set => S_CLAS_FICHA = value;
        }
        public int Vig_Ficha
        {
            get => I_VIG_FICHA;
            set => I_VIG_FICHA = value; 
        }
        public int Agil_Ficha 
        {
            get => I_AGIL_FICHA;
            set => I_AGIL_FICHA = value;
        }
        public int For_Ficha
        {
            get => I_FOR_FICHA; 
            set => I_FOR_FICHA = value;
        }
        public int Vel_Ficha
        { get => I_VEL_FICHA; 
            set => I_VEL_FICHA = value;
        }
        public int Perc_Ficha 
        {
            get => I_PERC_FICHA;
            set => I_PERC_FICHA = value; 
        }
        public string Tam_Ficha
        {
            get => S_TAM_FICHA;
            set => S_TAM_FICHA = value; 
        }
        public int Car_Ficha
        {
            get => I_CAR_FICHA;
            set => I_CAR_FICHA = value;
        }
        public int Forv_Ficha
        {
            get => I_FORV_FICHA; 
            set => I_FORV_FICHA = value; 
        }
        public int Inte_Ficha
        { 
            get => I_INTE_FICHA; 
            set => I_INTE_FICHA = value; 
        }
        public int Xp_Ficha
        { 
            get => I_XP_FICHA;
            set => I_XP_FICHA = value;
        }
        public string Def_Ficha
        {
            get => S_DEF_FICHA; 
            set => S_DEF_FICHA = value; 
        }
        public string Apt_Ficha
        { 
            get => S_APT_FICHA;
            set => S_APT_FICHA = value;
        }
        public string Ant_Ficha
        {
            get => S_ANT_FICHA;
            set => S_ANT_FICHA = value;
        }
    }
}
