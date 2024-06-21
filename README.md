通过调用Everything的SDK，实现全盘批量文件的搜索，并将查找到的第一个结果复制到指定路径。
使用前请先自行下载安装Everything：https://www.voidtools.com/。
SDK基于Everything版本为：版本 V1.4.1.1024。
界面如下：
![image](https://github.com/ChrisHang/FileSearchByEverything/assets/14013397/21693e8e-dc70-4139-b2ec-9b87bcf6cf23)
在搜索文件清单框里输入要搜索的文件名称，不同文件名用换行分隔；
点击选择路径，选择一个将搜索到文件另存的路径；
点将开始查找，开始执行任务，按顺序搜索输入的文件名，并对第一个结果复制到选择的路径，同时打印日志；
