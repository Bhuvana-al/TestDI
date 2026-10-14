using System;
using DataList.Interfaces;
using DataList.Services;
using DataList.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DataList.Helpers;

public static class ServiceCollectionExtensions
{
public static void AddServices(this IServiceCollection collection)
    {
        collection.AddSingleton<MainWindowViewModel>();
        //collection.AddTransient<MainWindowViewModel>();
        collection.AddTransient<IMovieServices, MovieServices>(); //dependency injection
    }
}
