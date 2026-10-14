using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using DataList.ViewModels;

namespace DataList;

public class ViewLocator : IDataTemplate
{
 public Control? Build(object? data)
    {
        if (data is null) return null;

        //Skapa en view(sida)...
        var viewName = data.GetType().FullName!.Replace("ViewModel", "ViewModel", StringComparison.InvariantCulture);
        var view = Type.GetType(viewName);

        if (view is null) return null;

        var control = (Control)Activator.CreateInstance(view)!;
        control.DataContext = data;

        return control;
    }

    public bool Match(object? data) => data is MainWindowViewModel; 
}
