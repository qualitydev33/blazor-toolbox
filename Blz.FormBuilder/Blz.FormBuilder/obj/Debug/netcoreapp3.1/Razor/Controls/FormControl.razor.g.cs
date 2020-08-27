#pragma checksum "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "397bd14704539af3c1524195d97b4ec5b3832508"
// <auto-generated/>
#pragma warning disable 1591
namespace Blz.FormBuilder.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder.Shared;

#line default
#line hidden
#nullable disable
    public partial class FormControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h5 style=\"margin-bottom:20px;\">FormControl</h5>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "formcontrol-container");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 3 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
     for (int i = 0; i < AllControls.Count; i++)
    {
        if (i == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenComponent<Blz.FormBuilder.Controls.DropableFormArea>(5);
            __builder.AddAttribute(6, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                      i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "CurrentForm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blz.FormBuilder.Controls.FormControl>(
#nullable restore
#line 7 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                       this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 8 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
        }
        if (AllControls[i].GetType() == typeof(HeaderFormControl))
        {
            HeaderFormControl ctrl = AllControls[i] as HeaderFormControl;

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenComponent<Blz.FormBuilder.Controls.HeaderFormControl>(10);
            __builder.AddAttribute(11, "HeaderText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                            ctrl.HeaderText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "HeaderInputBg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                                             ctrl.HeaderInputBg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                                                                         i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "CurrentForm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blz.FormBuilder.Controls.FormControl>(
#nullable restore
#line 12 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                                                                                          this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 13 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"

        }
        if (AllControls[i].GetType() == typeof(TextEntryFormControl))
        {
            TextEntryFormControl ctrl = AllControls[i] as TextEntryFormControl;

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenComponent<Blz.FormBuilder.Controls.TextEntryFormControl>(17);
            __builder.AddAttribute(18, "EntryText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                              ctrl.EntryText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "EntryBg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                                        ctrl.EntryBg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                                                              i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "CurrentForm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blz.FormBuilder.Controls.FormControl>(
#nullable restore
#line 18 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                                                                               this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 19 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
           
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenComponent<Blz.FormBuilder.Controls.DropableFormArea>(24);
            __builder.AddAttribute(25, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                   i+1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "CurrentForm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blz.FormBuilder.Controls.FormControl>(
#nullable restore
#line 21 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
                                                       this

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 22 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\GIT\blzFormBuilder\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Controls\FormControl.razor"
       
    [Parameter]
    public List<BaseEditorControl> AllControls { get; set; }
    [Parameter]
    public string ControlNameFromProperty { get; set; }
    [Parameter]
    public string ControlBgFromProperty { get; set; }

    public FormControl() { }

    public FormControl(List<BaseEditorControl> allControls) {
        this.AllControls = allControls;
    }


    public void MovingControl(int DropIndex)
    {
        var draggedControl = AllControls[CurrentDragIndex];

        if (DropIndex < AllControls.Count)
        {
            AllControls.Insert(DropIndex, draggedControl);
        }
        else
        {
            AllControls.Add(draggedControl);
        }
        if (CurrentDragIndex > DropIndex)
        {
            AllControls.RemoveAt(CurrentDragIndex + 1);
        }
        else
        {
            AllControls.RemoveAt(CurrentDragIndex);
        }

        CurrentDragIndex = -1;
        StateHasChanged();
    }

    public int CurrentDragIndex = -1;

    private void HandleDragEnter()
    { 
        Console.WriteLine("Drag enter");
    }
    private void HandleDragLeave()
    { 
        Console.WriteLine("Drag leave");
    }

    public void UpdateControls()
    {
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
