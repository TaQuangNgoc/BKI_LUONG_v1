ALTER database dbname
set  SINGLE_USER  with ROLLBACK IMMEDIATE 
 


restore database dbname
from disk = 'C:\backupDB\bki_luong.bak'
with replace, KEEP_REPLICATION

ALTER database dbname
set  MULTI_USER with ROLLBACK IMMEDIATE 