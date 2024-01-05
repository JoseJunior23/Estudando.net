USE [Courses];

INSERT INTO [Category]([Name]) VALUES('Backend')
INSERT INTO [Category]([Name]) VALUES('Frontend')
INSERT INTO [Category]([Name]) VALUES('Mobile')

INSERT INTO [Course]([name], [CategoryId]) VALUES('Fundamentos c#', 1)
INSERT INTO [Course]([name], [CategoryId]) VALUES('Fundamentos de  OOp', 1)
INSERT INTO [Course]([name], [CategoryId]) VALUES('Angular', 2)
INSERT INTO [Course]([name], [CategoryId]) VALUES('Flutter', 3)