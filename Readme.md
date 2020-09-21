# DreamFlat
DreamFlat is your Ultimate Need for Real Estate solution in the world. 

##Introduction:
DreamFlat is the BEST real estate service in BD completely equipped with Buying, Selling, Renting and Bidding features. It also provides Developer APIs with complete documentation. 

##System Requirements:
  - Visual Studio 2019
  - Microsoft .NET Framework 4.5 or later
  - IIS 7 or higher
  - Microsoft® SQL Server 2012 Express or later
  - Make SURE TO Install Local DB with Microsoft® SQL Server 2012 Express or later
  - Only installing the localDB.msi may also work

##System Specifications:
  - ASP.NET MVC 5
  - ASP.NET WEB API 2.2
  - ASP.NET Identity 2.0
  - ASP.NET SignalR
  - Bootstrap 4
  - EntityFramework 6
  - Json.NET
  - Quartz.NET

 

#Getting Started

  - Download DreamFlat source code.
  - Unzip DreamFlat and copy it the Projects folder of Visual Studio 2019 or any other location.
  
    ###Build Project

- Open Project in Visual Studio 2019.
- Open **ControlDesk > Index.cshtml** file under Views folder of project solution.
- Build project **Build > Build Solution** or **Ctrl+Shift+B**.
- Go to **Debug** menu and select **Start Debugging** or **F5**.
- When project is loaded in browser it prompts with **Login Screen**.
- Enter **Admin** Username and Password from **Passwords.txt** provided in project source.
- After successful Login, system takes you the **Configuration** page.

    ###View Project

- you can then log out and login as **Agent** to create a property, upload images, set address or many other things.
- Or you can login as **Member** to view all property, bid for it, hire an agent to buy it and may things

    ###View Documentation

- If you want to see the complete API documentation you can login as **Developer** and click on API section.

    ###View Database

- Want to see the Database? then you have to open the SQl Server Management Studio and set server name as **(localdb)\yourlocalDB** 
and set Authentication as **Windows Authentication** and then click connect. you will see the database as **DREAMFLAT_2_1_BETA**
- if you want to find the name of your local DB, go to **CMD** and type **SQLLocalDB info** and check the state by **SQLLocalDB info *yourlocalDB***



##Developers
- Faysal Ahmed (170104137)
- Foisal Reza (170104152)
- Arafat Yousuf (170104140)


###Updates

  - Some Bugs has been partially fixed.
  - Unfortunately, Some bugs Still Remaining.
  - Google Map is Behaving Weirdly and so it is still under Construction