create or replace
procedure liked_artists (album_name in VARCHAR2 ,artist_name out sys_refcursor )
as
begin

open artist_name for
select artist_name 
from album
WHERE album_name= album_name;
end;
