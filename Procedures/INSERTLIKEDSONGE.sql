create or replace
procedure insertlikedsonge
(username in varchar2 ,songname in varchar2)  
is
begin
  INSERT INTO user_songs 
  VALUES (username, songname);

  COMMIT;
END;
