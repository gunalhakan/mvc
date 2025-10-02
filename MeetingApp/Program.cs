var builder = WebApplication.CreateBuilder(args);
// Boş proje içinde Controller ve Views kullanmak için yazılır.
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Default routing ayarları için yazılıyor. (Controller/Action/id)
//app.MapDefaultControllerRoute();
//Yukarıdaki kod ile aynı işi yapıyor, bir routing pattern i oluşturuyor.

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


//app.MapGet("/", () => "Hello World!");

app.Run();
