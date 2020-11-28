create or replace
procedure getsongsofplaylist
(songname in VARCHAR2 ,songlink out sys_refcursor)  
is
begin
open songlink for
SELECT SONGLink  
from song
where song_name= songname;
end;
