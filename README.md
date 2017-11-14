# FIT-PEP-SeminarskiRad: Centar za edukaciju
The project was made as part of "Principles of e-business" course at faculty of information technologies, Mostar.

Topic: Education center<br>
Course: Principles of e-business

The functionality of the application is divided into two parts: desktop and mobile.
Desktop functionality serve as the secondary side of the system, which has the role of maintaining and administering the system.
Mobile functionality is the primary, it is used by the center's candidates to get the needed service. 
Both, desktop and mobile applications share the same Web API, which represent an interface to database server.

### Functional requirements
  - Mobile(Windows phone 8.1):
    - registration
    - Login
    - Overview of active groups
    - rate course
    - system of product recommendations(collaborative filtering)
  - Desktop(Windows forms):
    - promote application requirements
    - records of course data
    - records of group data
    - records of the candidate payments 
    - certification
    - SMS notification system
    
### Technical implementation
- Web API:
  - ASP.NET Web API 2
  - C#
  - LINQ
  - Entity Framework(code first)
- Mobile:
  - Windows phone 8.1
  - C#
- Desktop:
  - Windows forms
  - C#
  - Report
  - Infobip API(SMS notification)
