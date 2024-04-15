
using HomeWork8.SecondTask;

namespace HomeWork8.ThirdTask
{
    internal class Registor
    {
        private Document[] registor = new Document[10];
        private int counter = 0;

        public bool AddNewDoc(Document document)
        {       
            if(counter < registor.Length)
            {
                registor[counter] = document;
                counter++;
                Console.WriteLine($"The document has been added to the register successfully.");
                return true;
            }

            else
            {
                Console.WriteLine("The place is over. Create new registor");
                return false;
            }
        }

        public void GetInfo()
        {
            for(int i = 0; i < registor.Length; i++)
            {
                registor[i].GetInfo();
            }
        }
    }
}
