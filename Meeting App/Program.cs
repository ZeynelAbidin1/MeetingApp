namespace MeetingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();

            //controller/action/id?
            //iki farkl� yol 
            //app.MapDefaultControllerRoute();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
