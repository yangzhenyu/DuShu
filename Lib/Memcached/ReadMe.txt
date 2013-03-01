如何搭建Memcached: 

1、将memcached.exe放至指定目录，如：C:\Memcached\。 
2、用cmd打开命令窗口，转到memcached.exe的目录，输入 “memcached.exe -d install”。
3、打开控制面板，打开服务，可以看到memcached已经在上面可，如果没有启动，则手动启动一下。
4、使用telnet命令 验证缓存服务器是否可用。默认的端口为：11211
5、telnet后开始什么都不显示，回车后输入命令 stats 查看统计信息，说明服务器运作正常。


其它的内容，可以参与http://www.jb51.net/article/30334.htm
连接Memcached的.net的客户端：http://code.google.com/p/memcached/wiki/Clients