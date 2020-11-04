using jon.Models;

namespace jon.Models{

    public partial class Pikachu : Pokemon{

        public string type { get; set; }
        public string name { get; set ; }
        public Pikachu (){
            this.type = "Pikachu" ;
        }

    }

}