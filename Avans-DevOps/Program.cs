using Avans_DevOps.Domain;
using Avans_DevOps.Domain.CompositePattern.ForumCompositePattern;
using Avans_DevOps.Domain.Forum;
using Avans_DevOps.Domain.Sprint;
using Avans_DevOps.Domain.Strategy_Pattern;
using Avans_DevOps.Domain.Users;

//Users
ProductOwner timothy = new ProductOwner("Timothy", "timothy@gmail.com", "email");
ScrumMaster joy = new ScrumMaster("Joy", "joy@gmail.com", "email");
Developer matthijs = new Developer("Matthijs", "matthijs@gmail.com", "slack");
Developer jaron = new Developer("Jaron", "jaron@gmail.com", "email");
Developer lucas = new Developer("Lucas", "lucas@gmail.com", "slack");
Tester ayrianna = new Tester("Ayrianna", "ayrianna@gmail.com","email");
Tester arno = new Tester("Arno", "arno@gmail.com", "email");
Tester ruud = new Tester("Ruud", "ruud@gmail.com", "slack");

//Product Backlog
ProductBacklog productBacklog = new ProductBacklog();

//Project
Project avansDevopsProject = new Project("Avans DevOps", productBacklog, joy, timothy, new List<Developer> { matthijs, jaron, lucas }, new List<Tester> { ayrianna, arno, ruud });

//Sprints
FeedbackSprint firstSprint = new FeedbackSprint("Sprint 1", new DateTime(2024, 1, 1), new DateTime(2024, 3, 30));
ReleaseSprint secondSprint = new ReleaseSprint("Sprint 2", new DateTime(2024, 3, 1), new DateTime(2024, 6, 30));
FeedbackSprint thirdSprint = new FeedbackSprint("Sprint 3", new DateTime(2024, 6, 1), new DateTime(2024, 9, 30));
ReleaseSprint fourthSprint = new ReleaseSprint("Sprint 4", new DateTime(2024, 10, 1), new DateTime(2024, 12, 30));

//Backlog Items, States and Activities
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

BacklogItem backlogItem2 = new BacklogItem("Gebruikers formuleer maken", jaron);
backlogItem2.AddActivity(new Activity("Field validation maken", lucas));
backlogItem2.AddActivity(new Activity("Form designen", jaron));
backlogItem2.AddActivity(new Activity("Designen van form page", lucas));


productBacklog.addItem(backlogItem);
productBacklog.addItem(backlogItem2);

//Forum, Threads and Posts
Forum forum = new Forum("Avans DevOps Forum");
DiscussionThread newThread = new DiscussionThread("Welkom op het forum!");
ForumComposite forumComposite = new ForumComposite();

forum.AddThread(newThread);
forumComposite.AddPost(new Post("Welkom op het forum! Hier kunnen we discussiëren over het Avans DevOps project.", timothy), newThread);
forumComposite.AddPost(new Post("Hallo! Ik ben Matthijs en ik ben een developer.", matthijs), newThread);


//Sprint States
firstSprint.SetExecuteState();
firstSprint.SetFinishState();

secondSprint.SetCancelState();
secondSprint.SetInitializeState();
secondSprint.SetExecuteState();
secondSprint.SetFinishState();

//Sprint Reports
firstSprint.ExportSprintReport("Avans Hogeschool", "logo", "Avans DevOps Sprint 1", "1.0", new DateTime(2024, 3, 30), new PdfStrategy());
secondSprint.ExportSprintReport("Avans Hogeschool", "logo", "Avans DevOps Sprint 2", "2.0", new DateTime(2024, 6, 30), new PngStrategy());