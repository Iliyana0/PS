using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            User user = new User();
            user.Names = "Iliyana";
            user.Password = "123456";
            user.Role = Others.UserRolesEnum.STUDENT;
            user.FacultyNumber = "121221083";
            user.Email = "iignatova@tu-sofia.bg";


            UserViewModel userViewModel = new UserViewModel(user);
      

            UserView view = new UserView(userViewModel);
            

            view.Display();
         

            view.DisplayDetailed();
            

            view.DisplayTable();
   

        }
    }
}