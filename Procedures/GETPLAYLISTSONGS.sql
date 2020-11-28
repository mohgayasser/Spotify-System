create or replace
procedure getplaylistsongs
(playlistid in NUMBER ,song_name out sys_refcursor)  
is
begin
OPEN song_name for
SELECT song_name 
from playlistandsong
where playlist_id= playlistid;
end;
