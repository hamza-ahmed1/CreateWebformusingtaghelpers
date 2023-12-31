var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();//for accessing wwwroot files in our application

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

#region Summary
/*
 * asp-for tag helper for input fiels:bind feild with property of model
 * radio button:
 * Example Explained
To style checkboxes, use a wrapper element with class="form-check" to ensure proper margins for labels and checkboxes.

Then, add the .form-check-label class to label elements, and .form-check-input to style checkboxes properly inside the .form-check container.

Use the checked attribute if you want the checkbox to be checked by default.
form-floating is used for floating label placeholder is required even they not shown
  *
 */
#endregion

#region Model Binding
/*
 * It is simple concept that maps the HTTP request to action method parameter
 * https://localhost:7151/Home/Index/3?name=Hamza for model  binding
 * How model Binding works:
 * Order
 * 1--Form Values:they go in the HTTP request using POST method
 * 2--Route Values:https://localhost:7151/Home/Index/3
 * 3--Query string :https://localhost:7151/Home/Index/3?name=Hamza
 * stored as name-values pair:
 * 
 */
#endregion
#region Model validator
/*
 * asp-validation
 * gives as attributes to restrict from invalid data
 * model bider just  only not bind our value also model validator
 * runs after the model binding
 * 1--[required] :null values are not allowed custom messege allowed
 * 2--[stringLength(15,Minimumlength)]:specify max and min length of string
 * 3--[Range(n1,n2)]
 * 4--[Regularexpression("regix")]
 * 5--[Compare("propname",error)]
 * 6--[URL(error)]
 * 7--[MaxLength]
 * 8--[MinLength]
 * 
 */
#endregion

#region Validation Tag Helper
/*asp-validation-summary
 * <div asp-validation-summary="All">
    for validation of all fields in the form :
   </div>
 */
#endregion
