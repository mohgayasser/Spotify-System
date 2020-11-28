create or replace
procedure liked_artists_albumsofartists (songname in VARCHAR2 ,album_name out sys_refcursor )
as
begin
open album_name for
select album_name
from song
WHERE song_name= songname;
end;
