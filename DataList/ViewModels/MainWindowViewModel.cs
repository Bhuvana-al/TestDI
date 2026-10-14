using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DataList.Interfaces;
using DataList.Models;
using DataList.Services;

namespace DataList.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    private IMovieServices _movieService;

    [ObservableProperty]
    public partial ObservableCollection<Movie> Movies {get; set; } = [];
    
    public MainWindowViewModel(IMovieServices movieService)
    {
        _movieService = movieService;
    }
    [RelayCommand]
    private void ShowRomantic()
    {
        Movies = new ObservableCollection<Movie>(_movieService.ListRomantic());
    }
    [RelayCommand]
    private void ShowThriller()
    {
        Movies = new ObservableCollection<Movie>(_movieService.ListThriller());
    }       
    
}
