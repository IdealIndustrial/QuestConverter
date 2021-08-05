# QuestConverter
Quest file converter for Better Quests Minecraft mod.

It makes a separate lang file from "name" and "description" properties of quests and quest lines.

Usage: 

```QuestConverter.exe "path to your DefaultQuests.json"```

Then it asks for two filenames one for the lang file(default is en_US.lang) and one for the new localized DefaultQuests.json(default is DefaultQuests.json).
  
Localization keys are generated automatically based on quest Ids and quest line Ids.
