using Avans_DevOps;
using Avans_DevOps.BacklogItem;


BacklogItem backlogItem = new BacklogItem("Douchen met de meiden");
backlogItem.AddActivity(new Activity("Laat je verkeerd informeren"));
backlogItem.AddActivity(new Activity("Doe alsof de deur op slot zit"));
backlogItem.AddActivity(new Activity("Naar de douche lopen"));

BacklogItem backlogItem2 = new BacklogItem("Matthijs op de fiets");
backlogItem2.AddActivity(new Activity("Maak je fiets schoon"));
backlogItem2.AddActivity(new Activity("Zet je helm op"));
backlogItem2.AddActivity(new Activity("Ga tv kijken"));


ProductBacklog productBacklog = new ProductBacklog();
productBacklog.addItem(backlogItem);
productBacklog.addItem(backlogItem2);

Project project = new Project("Matthijs wil samen douchen", productBacklog);