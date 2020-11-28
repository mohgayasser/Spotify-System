create or replace
procedure UNlike_Song (username in VARCHAR2,songname in VARCHAR2 )
as
begin
DELETE from user_songs
where song_name= songname and
user_name= username;
end;
