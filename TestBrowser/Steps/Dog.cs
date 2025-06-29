using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestBrowser.Steps
{
    internal class Dog : Animal
    {
        //ERRO: ordem de inicializacao nao garante que propriedade AnimalName ja esta pronto para ser usado.
        public string DogName { get; set; } = AnimalName;

        //ERRO: ordem de inicializacao nao garante que campo AnimalColor vai esta pronto em tempo de execucao
        public string DogColor = AnimalColor;

        public Dog() : base("alive")
        {
            
        }


        public void PrintDogColor()
        {
            //da pra garantir que AnimalColor vai esta pronto
            Console.WriteLine(AnimalColor);
        }

        public void PrintDogName()
        {
            //dentro de metodos da pra garantir que a propriedade AnimalName da classe mae ja existe
            Console.WriteLine($"My name {AnimalName}");

            AnimalName = "Bruce";
        }

        public void PrintBreath()
        {
            //Breath eh do tipo leitura somaente!!
            Breath = "my breath";
        }
    };




}
