SET IDENTITY_INSERT [dbo].[WeatherForecasts] ON
--- Inserting seed data for WeatherForecasts
INSERT INTO [dbo].[WeatherForecasts] ([Id], [Date], [TemperatureC], [Summary]) 
VALUES 
(1, '2021-01-01T00:00:00', 25, 'Freezing'),
(2, '2021-01-02T00:00:00', 35, 'Scorching'),
(3, '2021-01-03T00:00:00', 45, 'Hot'),
(4, '2021-01-04T00:00:00', 55, 'Warm'),
(5, '2021-01-05T00:00:00', 65, 'Mild'),
(6, '2021-01-06T00:00:00', 75, 'Cool');

SET IDENTITY_INSERT [dbo].[WeatherForecasts] OFF