在mysql workbench中，设置sys为默认数据库，
单击文件、运行 SQL 脚本...，选择 accounts.sql 文件，在Default Schema 名称下选择 sys，然后单击运行，再单击关闭以将默认帐户表结构导入数据库。
对所有剩余文件 actionbars.sql、characters.sql、equipments.sql、globals.sql 和 inventory.sql 重复上一步，以完成所有其他所需表结构的设置。
现在您可以关闭 Workbench 应用程序，因为我们已经完成数据库设置，并且服务器应用程序已准备好使用它

Clone my mmo-server-database-files repo onto your computer, this includes all of the .sql files we will execute to quickly and easily set up all the correct table structures that are required for the game server to interact with the database correctly
Run the MySQL Workbench application, this is useful for managing the active database during development such as when you may need to make manual changes to the database or check the value or something while testing and debugging later on
Click the + button next to MySQL Connections to set up a new connection for connecting to and managing the server that we set up earlier
Put whatever you want into the Connection Name, under Hostname you want to put in your computers local IPv4 address (found by entering ipconfig in the command window), then enter in the username and password that you created during the database initialization earlier
Click Test Connection to make sure you entered everything correctly if it works then you can click OK to finish setting up the connection.
The connection should now appear in the list, you can double click on it to connect to and start managing the database
Click File, Run SQL Script..., navigate to the mmo-server-database-files repo on your computer, select the accounts.sql file, under Default Schema Name select sys, then click Run and then Close to import the default accounts table structures into the database.
Repeat the previous step for all of the remaining files actionbars.sql, characters.sql, equipments.sql, globals.sql and inventories.sql to finish setting up all of the other required table structures.
Now you can close the Workbench application as we have finished setting up the database and its ready to be used by the server application