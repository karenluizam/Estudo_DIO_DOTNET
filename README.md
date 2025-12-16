# New Project + Bugs in the old one - December 16th 2025

## About
This repository was created to replace the old one, because had too many errors. I'm here to explain what happened – although I still don't know why that happened.

⚠ I'm a begginer, so some things I say here may not be precise.

## Errors in the project
I was taking a class about Solutions and how to organize the project in VS Code. I followed everything the teacher was saying, however, things would not go as planned, and I kept getting error masseges.

What was not working:
- I couldn't move the csproj file and the obj folder to a new one in order to organize the code - they just refused to get into a new folder.
- When I added a referance to my project in the Solution tab, the error CS0436 appeared while trying to use one of the classes I had created.
- When I tried to run the program after solving the CS0436 issue, a new error appeared: CS0579, which stated my class was duplicated.

I tried looking for answers, but couldn't find any. After hours of searching for solutions, I was so stressed I wasn't thinking straight anymore, so I called it a day.

## How I solved it
One day later, I've noticed the error only showed up when I would create a Class Library under my Solution after my project was already in the Explorer.
So I decided to take the opposite route and create a new project directly in the Solution.
And it worked just fine! The Solution makes folders when you create a new file, so the organization was not an issue anymore. And referencing the projects was quick and easy, so my classes could finally be used.

## Final thoughts
I am not sure why creating a class library after I already have a project would affect it so much.
From what I read, it probably has something to do with where the .SLN file is creacted, which should not be in a sub folder. But I still don't understand how the teacher's project worked fine. Maybe a difference in .NET version?
Well, hopefully I will find out the reasons in my learning journey. But I absolutely learned one thing: when the code doesn't work, let the code, and your mind, rest a little bit.
