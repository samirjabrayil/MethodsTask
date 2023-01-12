

namespace MethodsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TASK1
            //-Massivdeki elementlerden kvadrat koku olanlari tapib,onlardan yeni massiv yaradib geri qaytarirsiz.

            var arrayTasks = new ArrayTasks();

            var mass = arrayTasks.EnterArray();

            arrayTasks.Print(mass);

            var newarray = arrayTasks.FindNumbers(mass);

            Console.WriteLine("Kvadrat koku olan ededlerden ibaret  massviv:");
            arrayTasks.Print(newarray);

            #endregion

            #region TASK2
            //-Parameter kimi gonderilen ededin ters yazilisindan alinan ededi geri qaytarirsiz. 


            //var numberTasks = new NumberTasks();

            //var newnumber = numberTasks.EnterNumber();

            //Console.Write("Number is ");
            //numberTasks.Print(newnumber);

            //var reversenumber = numberTasks.ReserveNumber(newnumber);

            //Console.Write("Reverse number is ");
            //numberTasks.Print(reversenumber);

            #endregion
        }
    }
}