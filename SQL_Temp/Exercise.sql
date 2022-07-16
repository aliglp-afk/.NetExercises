/****** Script for SelectTopNRows command from SSMS  ******/

SELECT * FROM Soccer_city
WHERE city_id = (SELECT city_id FROM soccer_venue
WHERE venue_id = (SELECT MM.venue_id
  FROM [SOCCER_DB].[dbo].[match_mast] MM 
  WHERE [match_no]=1))

/* 2 */
SELECT venue_name FROM [dbo].[soccer_venue] V
WHERE V.venue_id = (SELECT MM.venue_id
  FROM [SOCCER_DB].[dbo].[match_mast] MM 
  WHERE [match_no]=(SELECT MAX(match_no) FROM [SOCCER_DB].[dbo].[match_mast] MM ))

/*3 */

SELECT referee_name,C.country_name
  FROM [SOCCER_DB].[dbo].[match_mast] MM
  INNER JOIN [dbo].[referee_mast] R ON MM.[referee_id] = R.[referee_id]
  INNER JOIN [dbo].[Soccer Country] C ON C.country_id = R.country_id
  WHERE MM.match_no = (SELECT MAX(match_no) FROM [SOCCER_DB].[dbo].[match_mast] MM )

SELECT referee_name
  FROM [SOCCER_DB].[dbo].[match_mast] MM
  INNER JOIN [dbo].[referee_mast] R ON MM.[referee_id] = R.[referee_id]
  WHERE MM.match_no = 1
/* 4 */
SELECT [ass_ref_name],
		AC.country_name,
		R.referee_name,
	  C.country_name
	  FROM [SOCCER_DB].[dbo].[match_details] MT
INNER JOIN [SOCCER_DB].[dbo].[match_mast] MS ON MT.match_no = MS.match_no
INNER JOIN [dbo].[asst_referee_mast] AR ON AR.[ass_ref_id] =  MT.ass_ref
INNER JOIN [dbo].[referee_mast] R ON R.[referee_id] = MS.referee_id
INNER JOIN [dbo].[Soccer Country] AC ON AC.country_id = AR.country_id
INNER JOIN [dbo].[Soccer Country] C ON C.country_id = R.country_id
WHERE MT.match_no =2

(SELECT MAX(match_no) FROM [SOCCER_DB].[dbo].[match_mast] MM )

/* 5 */
SELECT MT.[match_no],SC.[country_name],SUM(MT.[goal_score]) GOALS_SCORED
  FROM [SOCCER_DB].[dbo].[match_details] MT INNER JOIN [dbo].[Soccer Country] SC 
  ON MT.[team_id] = SC.[country_id]
  GROUP BY ROLLUP(MT.[match_no]),(SC.[country_name])

SELECT SC.[country_name],SUM(MT.[goal_score]) GOALS_SCORED
  FROM [SOCCER_DB].[dbo].[match_details] MT INNER JOIN [dbo].[Soccer Country] SC 
  ON MT.[team_id] = SC.[country_id]
  GROUP BY (SC.[country_name])

SELECT * FROM Soccer_city WHERE city = Exec [dbo].[spu_GetCity] 20001



SELECT ASCII('?')

select CONCAT(REPLACE('asdf','a','A'),STUFF(CONCAT(REPLACE('Abcd1234%','Abc','a*'),REPLACE('Fbc1','bc','*')),4,0,' '))
select concat('1233', ' ', 'abc','def')
USE SOCCER_DB
SELECT * FROM [dbo].[player_booked] PB INNER JOIN  [dbo].[player_mast] P ON PB.player_id = P.player_id
SELECT VALUE FROM string_split('1234-1234-567-789','-')
--WHERE P.player_name LIKE 'Cristiano%'