﻿using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
	// TODO
	public static BMIResultRepository BMIResultRepo { get; set; }
	public App(BMIResultRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		// TODO
		BMIResultRepo = repo;
	}
}
