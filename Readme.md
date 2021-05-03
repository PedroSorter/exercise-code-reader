# Exercise - Code Reader

## Description
This .Net Core console application reads from `txt` files some code numbers and generates a report for all read codes.
The input files for this application look like this:
```
   _  _     _  _  _ 
   _| _||_||_ |_   |
  |_  _|  | _||_|  | 
                    
```                           
Each entry is 4 lines long, and each line could contain multiple of 3 columns. The first 3 lines of each entry contain a code number written using pipes and underscores, and the fourth line is blank.
Each code number could have N digits, all of which should be in the range 0-9.

## Goals

### Goal 1
Your first task is to clone this repository in your local machine and create a branch from it. Open this solution in your preferred IDE, so you'll be ready for making a fix.

Once your environment is ready, run the tests where you'll notice from all tests 2 of them are failing. You can use the following command to run the tests:

    $ dotnet test
                             
Your goal here is to find the issue and fix it so all the tests should run correctly. 
**Hint:** The issue is related to only one code number.

### Goal 2
For this goal you will need to use the same branch you created in the first goal.
In this task you have to introduce the required changes to make the scanner supports reading the codes `8` and `9`.
So, the application should be able to identify code numbers like this: 
```
    _  _     _  _  _  _  _
  | _| _||_||_ |_   ||_||_|
  ||_  _|  | _||_|  ||_| _| 
                           
```
As part of this goal, you have to add tests to confirm your changes are working correctly.

### Goal 3
Save all your changes from previous goals and create a pull request in the repository 