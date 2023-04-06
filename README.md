# ETS-FrameworkProg-5025201161

#### 1. Complete the Model\BMIResult.cs class. 
This class should represent the columns on the table (id, name, heigh, weight, BMI Score, and 
Result). 

#### 2. Complete the Repository\BMIResultRepository.cs class so it can be used to save the data to 
database.

#### 3. Complete the ViewModel\BMICalculatorViewModel.cs so it can be used for handling data 
input inside the view. 


#### 4. MainPage.xaml 
a. Use the appropriate xmlns:local to import the view models
b. Change the title into: “BMI Calculator Page”
c. Check all the bindings and make sure that your input can bind properly. 


#### 5. MainPage.xaml.cs 
a. Use the appropriate ViewModels as BindingContext 

#### 6. MauiProgram.cs 
a. Add the dbPath variable declaraƟon for SQLite database.
Use this file name format: BMIResult_StudentID_Name.db3
b. Add BMIResultRepository into builder.Services 


#### 7. App.xaml.cs 
a. Add the BMIResultRepository as a property and iniƟalize it inside the constructor. 

