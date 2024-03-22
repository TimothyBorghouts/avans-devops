using Avans_DevOps.Domain;
using Avans_DevOps.Domain.Sprint;
using Avans_DevOps.Domain.Users;

//Users
ProductOwner timothy = new ProductOwner("Timothy", "timothy@gmail.com", "appel123");
ScrumMaster joy = new ScrumMaster("Joy", "joy@gmail.com", "druif123");
Developer matthijs = new Developer("Matthijs", "matthijs@gmail.com", "banaan123");
Developer jaron = new Developer("Jaron", "jaron@gmail.com", "peer123");
Developer lucas = new Developer("Lucas", "lucas@gmail.com", "kiwi123");
Tester ayrianna = new Tester("Ayrianna", "ayrianna@gmail.com" , "sinaasappel123");
Tester arno = new Tester("Arno", "arno@gmail.com" , "mango123");
Tester ruud = new Tester("Ruud", "ruud@gmail.com" , "ananas123");

//Product Backlog
ProductBacklog productBacklog = new ProductBacklog();

//Project
Project avansDevopsProject = new Project("Avans DevOps", productBacklog, joy, timothy, new List<Developer> { matthijs, jaron, lucas }, new List<Tester> { ayrianna, arno, ruud });

//Sprints
Sprint firstSprint = new FeedbackSprint("Sprint 1", new DateTime(2024, 1, 1), new DateTime(2024, 3, 30));
Sprint secondSprint = new ReleaseSprint("Sprint 2", new DateTime(2024, 3, 1), new DateTime(2024, 6, 30));
Sprint thirdSprint = new FeedbackSprint("Sprint 3", new DateTime(2024, 6, 1), new DateTime(2024, 9, 30));
Sprint fourthSprint = new ReleaseSprint("Sprint 4", new DateTime(2024, 10, 1), new DateTime(2024, 12, 30));

//Backlog Items and Activities
BacklogItem backlogItem = new BacklogItem("Inlog pagina maken", matthijs);
backlogItem.AddActivity(new Activity("Frontend login pagina designen", lucas));
backlogItem.AddActivity(new Activity("Use cases opstellen", jaron));
backlogItem.AddActivity(new Activity("Database opzetten", matthijs));

BacklogItem backlogItem2 = new BacklogItem("Gebruikers formuleer maken", jaron);
backlogItem2.AddActivity(new Activity("Field validation maken", lucas));
backlogItem2.AddActivity(new Activity("Form designen", jaron));
backlogItem2.AddActivity(new Activity("", lucas));

productBacklog.addItem(backlogItem);
productBacklog.addItem(backlogItem2);






