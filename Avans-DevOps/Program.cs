﻿using Avans_DevOps.Domain;
using Avans_DevOps.Domain.Forum;
using Avans_DevOps.Domain.Sprint;
using Avans_DevOps.Domain.Users;

//Users
ProductOwner timothy = new ProductOwner("Timothy", "timothy@gmail.com", "appel123", "email");
ScrumMaster joy = new ScrumMaster("Joy", "joy@gmail.com", "druif123", "email");
Developer matthijs = new Developer("Matthijs", "matthijs@gmail.com", "banaan123", "slack");
Developer jaron = new Developer("Jaron", "jaron@gmail.com", "peer123", "email");
Developer lucas = new Developer("Lucas", "lucas@gmail.com", "kiwi123", "slack");
Tester ayrianna = new Tester("Ayrianna", "ayrianna@gmail.com" , "sinaasappel123", "email");
Tester arno = new Tester("Arno", "arno@gmail.com" , "mango123" , "email");
Tester ruud = new Tester("Ruud", "ruud@gmail.com" , "ananas123", "slack");

//Product Backlog
ProductBacklog productBacklog = new ProductBacklog();

//Project
Project avansDevopsProject = new Project("Avans DevOps", productBacklog, joy, timothy, new List<Developer> { matthijs, jaron, lucas }, new List<Tester> { ayrianna, arno, ruud });

//Sprints
//Sprint firstSprint = new FeedbackSprint("Sprint 1", new DateTime(2024, 1, 1), new DateTime(2024, 3, 30));
//Sprint secondSprint = new ReleaseSprint("Sprint 2", new DateTime(2024, 3, 1), new DateTime(2024, 6, 30));
//Sprint thirdSprint = new FeedbackSprint("Sprint 3", new DateTime(2024, 6, 1), new DateTime(2024, 9, 30));
//Sprint fourthSprint = new ReleaseSprint("Sprint 4", new DateTime(2024, 10, 1), new DateTime(2024, 12, 30));

//Backlog Items and Activities
BacklogItem backlogItem = new BacklogItem("Inlog pagina maken", matthijs);
Activity activity = new Activity("Database connectie maken", matthijs);
Activity activity1 = new Activity("Backend login pagina designen", jaron);
Activity activity2 = new Activity("Frontend login pagina designen", lucas);
Activity activity3 = new Activity("Use cases opstellen", jaron);
backlogItem.AddActivity(activity);
backlogItem.AddActivity(activity1);
backlogItem.AddActivity(activity2);
backlogItem.AddActivity(activity3);

backlogItem.SetDoingState();
backlogItem.SetReadyForTestingState();
backlogItem.SetTestingState();
backlogItem.SetTestedState();
activity.finishActivity();
activity1.finishActivity();
activity2.finishActivity();
activity3.finishActivity();
backlogItem.SetDoneState();

//BacklogItem backlogItem2 = new BacklogItem("Gebruikers formuleer maken", jaron);
//backlogItem2.AddActivity(new Activity("Field validation maken", lucas));
//backlogItem2.AddActivity(new Activity("Form designen", jaron));
//backlogItem2.AddActivity(new Activity("Designen van form page", lucas));


productBacklog.addItem(backlogItem);
//productBacklog.addItem(backlogItem2);

//Forum, Threads and Posts
//Forum forum = new Forum("Avans DevOps Forum");
//Thread newThread = new Thread("Welkom op het forum!");
//forum.Threads.Add(newThread);
//newThread.Posts.Add(new Post("Welkom op het forum! Hier kunnen we discussiëren over het Avans DevOps project.", timothy));
//newThread.Posts.Add(new Post("Hallo! Ik ben Matthijs en ik ben een developer.", matthijs));






