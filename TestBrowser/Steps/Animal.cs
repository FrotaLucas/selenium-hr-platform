using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBrowser.Steps
{
    internal abstract class Animal  
    {
        public string AnimalName { get; set; } = "default";

        public string AnimalColor = "default";

        protected string Alive { get; set; }

        public string Breath { get; }

        protected Animal(string alive)
        {
            this.Alive = alive;

            //atribuicao permitida somente no constructo
            Breath = "breath";
        }


        protected void breath()
        {
            //LEITURA PERMITIDO
            var firstBreath = Breath;

            //Atribuicao nao permitido
            Breath = "default";
        }
    }
}
