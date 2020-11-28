create or replace
PROCEDURE GET_ALL_Songs
(Songname in varchar ,song_link out VARCHAR2)
is
BEGIN 
SELECT SONGLINK
into song_link
from song
where song_name= Songname;
end;
