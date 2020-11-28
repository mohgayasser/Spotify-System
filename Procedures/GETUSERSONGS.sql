create or replace
procedure getusersongs
(username in varchar,song out sys_refcursor )
is
begin
open song for
SELECT  song_name
from user_songs
WHERE user_name= username;
end;
