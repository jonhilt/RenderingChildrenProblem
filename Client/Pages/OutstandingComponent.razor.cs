using Microsoft.AspNetCore.Components;

namespace RenderingChildrenProblem.Client.Pages;
public partial class OutstandingComponent
{
    [Inject]
    private PersonService? Service { get; set; }
}