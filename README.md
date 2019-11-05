# BooksExample
An application written in C#


## Description
Create a WPF application that uses the Books database and displays the result of the following queries:
- Get a list of all the titles and the authors who wrote them. Sort the result by title.
- Get a list of all the titles and the authors who wrote them. Sort the result by title. For each title sort the authors alphabetically by last name, then first name.
- Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names alphabetically by last name first then first name.


## Output
Get a list of all the titles and the authors who wrote them. Sort the result by title.
```output
 Authors and titles (ordered by titles):
	Paul           	Deitel         	Android for Programmers: An App-Driven Approach
	Harvey         	Deitel         	Android for Programmers: An App-Driven Approach
	Abbey          	Deitel         	Android for Programmers: An App-Driven Approach
	Michael        	Morgano        	Android for Programmers: An App-Driven Approach
	Harvey         	Deitel         	C How to Program
	Paul           	Deitel         	C How to Program
	Paul           	Deitel         	C++ How to Program
	Harvey         	Deitel         	C++ How to Program
	Harvey         	Deitel         	Internet & World Wide Web How to Program
	Paul           	Deitel         	Internet & World Wide Web How to Program
	Abbey          	Deitel         	Internet & World Wide Web How to Program
	Paul           	Deitel         	Java How to Program
	Harvey         	Deitel         	Java How to Program
	Harvey         	Deitel         	Simply Visual Basic 2010
	Paul           	Deitel         	Simply Visual Basic 2010
	Abbey          	Deitel         	Simply Visual Basic 2010
	Abbey          	Deitel         	Visual Basic 2012 How to Program
	Paul           	Deitel         	Visual Basic 2012 How to Program
	Harvey         	Deitel         	Visual Basic 2012 How to Program
	Harvey         	Deitel         	Visual C# 2012 How to Program
	Paul           	Deitel         	Visual C# 2012 How to Program
	Paul           	Deitel         	Visual C++ 2008 How to Program
	Harvey         	Deitel         	Visual C++ 2008 How to Program
	Dan            	Quirk          	Visual C++ 2008 How to Program
```

Get a list of all the titles and the authors who wrote them. Sort the result by title. For each title sort the authors alphabetically by last name, then first name.
```output
 Authors and titles (ordered by titles, author's last name, and author's first name):
	Abbey          	Deitel         	Android for Programmers: An App-Driven Approach
	Harvey         	Deitel         	Android for Programmers: An App-Driven Approach
	Paul           	Deitel         	Android for Programmers: An App-Driven Approach
	Michael        	Morgano        	Android for Programmers: An App-Driven Approach
	Harvey         	Deitel         	C How to Program
	Paul           	Deitel         	C How to Program
	Harvey         	Deitel         	C++ How to Program
	Paul           	Deitel         	C++ How to Program
	Abbey          	Deitel         	Internet & World Wide Web How to Program
	Harvey         	Deitel         	Internet & World Wide Web How to Program
	Paul           	Deitel         	Internet & World Wide Web How to Program
	Harvey         	Deitel         	Java How to Program
	Paul           	Deitel         	Java How to Program
	Abbey          	Deitel         	Simply Visual Basic 2010
	Harvey         	Deitel         	Simply Visual Basic 2010
	Paul           	Deitel         	Simply Visual Basic 2010
	Abbey          	Deitel         	Visual Basic 2012 How to Program
	Harvey         	Deitel         	Visual Basic 2012 How to Program
	Paul           	Deitel         	Visual Basic 2012 How to Program
	Harvey         	Deitel         	Visual C# 2012 How to Program
	Paul           	Deitel         	Visual C# 2012 How to Program
	Harvey         	Deitel         	Visual C++ 2008 How to Program
	Paul           	Deitel         	Visual C++ 2008 How to Program
	Dan            	Quirk          	Visual C++ 2008 How to Program
```

Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names alphabetically by last name first then first name.
```output
 Authors grouped by title:
	Android for Programmers: An App-Driven Approach:
		Abbey	Deitel
		Harvey	Deitel
		Paul	Deitel
		Michael	Morgano

	C How to Program:
		Harvey	Deitel
		Paul	Deitel

	C++ How to Program:
		Harvey	Deitel
		Paul	Deitel

	Internet & World Wide Web How to Program:
		Abbey	Deitel
		Harvey	Deitel
		Paul	Deitel

	Java How to Program:
		Harvey	Deitel
		Paul	Deitel

	Simply Visual Basic 2010:
		Abbey	Deitel
		Harvey	Deitel
		Paul	Deitel

	Visual Basic 2012 How to Program:
		Abbey	Deitel
		Harvey	Deitel
		Paul	Deitel

	Visual C# 2012 How to Program:
		Harvey	Deitel
		Paul	Deitel

	Visual C++ 2008 How to Program:
		Harvey	Deitel
		Paul	Deitel
		Dan	Quirk
```
