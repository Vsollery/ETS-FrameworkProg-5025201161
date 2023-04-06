# ETS-FrameworkProg-5025201161

#### 1. Complete the Model\BMIResult.cs class. 
This class should represent the columns on the table (id, name, heigh, weight, BMI Score, and 
Result). 

```c#
public class BMIResult
{
    // TODO
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public string name { get; set; }
    public double height { get; set; }
    public double weight { get; set; }
    public double BMIScore { get; set; }

    public string Result { get; set; }
}
```

#### 2. Complete the Repository\BMIResultRepository.cs class so it can be used to save the data to 
database.

```c#
public async void AddNewBMIResult(string name, double height, double weight, double BMIScore, string BMIResult)
{
    int result = 0;
    Init();
    // TODO
    result = conn.Insert(new BMIResult
    {
        name = name,
        height = height,
        weight = weight,
        BMIScore = BMIScore,
        Result = BMIResult
    });
```

#### 3. Complete the ViewModel\BMICalculatorViewModel.cs so it can be used for handling data 
input inside the view. 

```c#
public void Save()
{
    // TO DO
    App.BMIResultRepo.AddNewBMIResult(Name, Height, Weight, BMIScore, BMIResult);

}

[RelayCommand]
public void Clear()
{
    Name = "";
    Height = 0 ;
    Weight = 0;

}
```


#### 4. MainPage.xaml 
a. Use the appropriate xmlns:local to import the view models

```xaml
 x:Class="IUP_BMI_Calculator.MainPage"
 xmlns:local="clr-namespace:IUP_BMI_Calculator.ViewModel"
```
b. Change the title into: “BMI Calculator Page”

```xaml
Title="BMI CALCULATOR PAGE">
```
c. Check all the bindings and make sure that your input can bind properly. 




#### 5. MainPage.xaml.cs 
a. Use the appropriate ViewModels as BindingContext 
```c#
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		// TODO
		this.BindingContext = new BMICalculatorViewModel();
	}
}
```

#### 6. MauiProgram.cs 
a. Add the dbPath variable declaraƟon for SQLite database.
Use this file name format: BMIResult_StudentID_Name.db3

```c#
// TODO
string dbPath = FileAccessHelper.GetLocalFilePath("Rename BMIResult_5025201161_VeniaSollery.db3");
builder.Services.AddSingleton<BMIResultRepository>(s => ActivatorUtilities.CreateInstance<BMIResultRepository>(s, dbPath));

```
b. Add BMIResultRepository into builder.Services 
```c#
builder.Services.AddSingleton<BMIResultRepository>(s => ActivatorUtilities.CreateInstance<BMIResultRepository>(s, dbPath));
```

#### 7. App.xaml.cs 
a. Add the BMIResultRepository as a property and initialize it inside the constructor. 
```c#
// TODO
public static BMIResultRepository BMIResultRepo { get; set; }
public App(BMIResultRepository repo)
{
  InitializeComponent();

  MainPage = new AppShell();

  // TODO
  BMIResultRepo = repo;
}
```
#### RESULT

Testing with my name

![](/img/res.jpg)

After pressing clear button. It will clear the name and the height and weight will automatically reset to 0.

![](/img/res1.png)
