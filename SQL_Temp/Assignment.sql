/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  *
  FROM [SOCCER_DB].[dbo].[match_details] MT
  INNER JOIN [dbo].[Soccer Country] SC ON MT.[team_id] = SC.[country_id]
  /*First Match*/
  (SELECT TOP (1) SC.[country_name], MT.[goal_score]
  FROM [SOCCER_DB].[dbo].[match_details] MT 
  INNER JOIN [dbo].[Soccer Country] SC ON MT.[team_id] = SC.[country_id]
  WHERE MT.win_lose = 'W')
  UNION
  (SELECT TOP (1) SC.[country_name], MT.[goal_score]
  FROM [SOCCER_DB].[dbo].[match_details] MT 
  INNER JOIN [dbo].[Soccer Country] SC ON MT.[team_id] = SC.[country_id]
  WHERE MT.win_lose = 'L')
  /*First Match Winner*/
  (SELECT TOP (1) SC.[country_name] 'Winner', MT.[goal_score] 'Score'
  FROM [SOCCER_DB].[dbo].[match_details] MT 
  INNER JOIN [dbo].[Soccer Country] SC ON MT.[team_id] = SC.[country_id]
  WHERE MT.win_lose = 'W')
  /*MAX AUDIENCE*/
  SELECT  * 
  FROM [SOCCER_DB].[dbo].[match_mast] MM WHERE MM.audence = (SELECT Max([audence]) FROM [SOCCER_DB].[dbo].[match_mast])
  /*PORTUGAL VS HUNGARY*/
  (SELECT TOP (2) SC.[country_name], MT.[goal_score]
  FROM [SOCCER_DB].[dbo].[match_details] MT 
  INNER JOIN [dbo].[Soccer Country] SC ON MT.[team_id] = SC.[country_id]
  WHERE MT.match_no = 34)
  /*TEAM LOST AGAINS PORTUGAL IN FINAL*/
  (SELECT SC.[country_name], MT.win_lose
  FROM [SOCCER_DB].[dbo].[match_details] MT 
  INNER JOIN [dbo].[Soccer Country] SC ON MT.[team_id] = SC.[country_id]
  WHERE MT.win_lose = 'L' AND match_no=51)
  /*GOALS SCORED BY EVERY TEAM AND SUM*/
  SELECT MT.[match_no],SC.[country_name],SUM(MT.[goal_score]) GOALS_SCORED
  FROM [SOCCER_DB].[dbo].[match_details] MT INNER JOIN [dbo].[Soccer Country] SC 
  ON MT.[team_id] = SC.[country_id]
  GROUP BY ROLLUP(MT.[match_no]),(SC.[country_name])
  /*HOST OF THE EUROCUP 2016*/
  SELECT *
  FROM [dbo].[Soccer Country] SC
  WHERE SC.[country_id] = ALL
  (
	SELECT [country_id]
	FROM [SOCCER_DB].[dbo].[Soccer_city] CITY
	WHERE CITY.city_id = ALL 
		(
		SELECT [city_id]
		FROM [SOCCER_DB].[dbo].[soccer_venue] VEN
		WHERE VEN.city_id = CITY.city_id
		)
  );