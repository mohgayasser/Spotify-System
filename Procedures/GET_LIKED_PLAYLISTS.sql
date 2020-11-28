create or replace
procedure GET_LIKED_PLAYLISTS(u_name in varchar, cur out sys_refcursor )
as
begin
open cur for
select playlist_id 
from manage_
where manage_.l_username = u_name;
end;
