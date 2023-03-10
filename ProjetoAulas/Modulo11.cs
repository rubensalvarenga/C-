namespace Modulo11
{
        public class TrabalhandoComDatas
        {
            public void AulaDateTime()
            {
                    var date1 = new DateTime (2012,12,02,19,22,23);
                    var date2 = DateTime.Parse("2022/12/22 19:25:23");
                    var date3 = DateTime.Now; //data e hora atual
                    var date4 = DateTime.Today; //só data

                    Console.WriteLine(date1);
                    Console.WriteLine(date2);
                    Console.WriteLine(date3);
                    Console.WriteLine(date4.ToString("dd-MM-yy"));
            }
        }


}