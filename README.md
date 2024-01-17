<h1>📊Student Grade Analyser Console App</h1>

I was reading up on Linqs(Language Integrated Query) in C# and wanted to build a short console application that could help me put the basics of Linqs into practice.
I hope this console app helps other beginners get more comfortable with Linqs.

The app provides very basic features for analyzing student data. 

<h2>🚀 Key Features</h2>
<ol>
<li><h4>Add Students:</h4></li>
Enter student names, grades, subject, and year.</br>
Build a list of students for analysis.

<li><h4>Display Students:</h4></li>
View a list of students with details like name, average grade, subject, and year.

<li><h4>Filter and Sort:</h4></li>
Filter students based on criteria such as minimum average grade.
Sort students by name, average grade, subject, or year.

<li><h4>Class Statistics:</h4></li>
Calculate class-wide statistics, including total students, average class grade, highest and lowest average grades.

<li><h4>User Interface:</h4></li>
Interactive console interface for easy navigation.
Options to perform various operations on student data.

<li><h4>Data Persistence:</h4></li>
Store and load student data for future sessions.

<li><h4>Error Handling:</h4></li>
Input validation to ensure data integrity.
</ol>

<h1>🏗 Tech Stack</h1>
<ul>
  <li>C#</li>
  <li>Visual Studio 2022</li>
</ul>

<h1>🔧 Improvements</h1>
<ul>
  <li>Storing student details in a database.</li>
  <li>Building a more interactive and user-friendly console interface by using a library like ConsoleGUI or Spectre.Console.</li>
</ul>

<h1>🎮 Video Demo</h1>
https://github.com/RoseIyera/Student-Grades-Analyzer/assets/103562933/2de86809-c915-4fe7-9039-4fa451e39439

<h1>👩🏾‍🦱Understanding LINQ for Beginners</h1>
LINQ (Language-Integrated Query) is a powerful feature in C# that allows you to write queries directly within your code to interact with data sources. 
In the context of this console application:
<ol>
<li><h4>Where Clause:</h4></li>
Used to filter elements based on a specified condition. For example, filtering students with an average grade above a certain threshold.

<li><h4>Select Clause:</h4></li>
Creates a new collection with specific information. In this case, selecting and displaying student names and average grades.

<li><h4>OrderBy Clause:</h4></li>
Sort elements in ascending or descending order. For instance, sorting students by name, average grade, or other attributes.

<li><h4>GroupBy Clause:</h4></li>
Groups elements based on a common attribute. Applied to categorize students by subject, year, or grade range.
Aggregation Methods (Average, Max, Min):
Used to perform calculations on a collection. For example, calculating the average, maximum, and minimum average grades for the entire class.
</ol>

I hope this helped you see how LINQ can be applied to your projects to work with data in a concise and readable manner.
