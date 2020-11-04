using jon.Models;

namespace jon.Models{

    public partial class Pikachu : Pokemon{

        public string type { get; set; }
        public string name { get; set ; }
        
        public int currentHP { get ; set ;  }
        
        public int maxHP { get; set ;  }
        public int lv { get ; set ; }
        public Pikachu (){
            this.type = "Pikachu" ;
        }
        public void setDefaultMaxHP (){
            this.maxHP = this.lv * 90 ;
        }
        

    }

}