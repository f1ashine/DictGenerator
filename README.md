# DictGenerator
## 0x00 免责声明
本工具旨在对网络安全从业人员和白帽子进行合法渗透测试时提供帮助，使用前请遵循相关法律法规，禁止用于任何非法用途。
## 0x01 简介
本工具基于`.Net Framework4.0`编写，工具运行后会在exe路径下生成`config.json`作为配置文件，思路参考[BaiLu-SED-Tool](https://github.com/HongLuDianXue/BaiLu-SED-Tool)，点击`生成字典`按钮在exe路径下生成`password.txt`文件。  
工具截图如下：  
![UI](https://raw.githubusercontent.com/f1ashine/DictGenerator/master/img/ui.png)
## 0x02 说明
字典组合方式分为3类：`信息类A`、`符号类B`、`常用字符类C`
1. A类字符  
考虑到可能存在`ABA`的组合情况，因此在生成字典时避免了同时出现两个A类（B类和C类同理）字符相同的情况。
由于A类字符种类比较多，程序就如下几种情况设计了输入：

|类型|描述|
|:----:|:--------:|
|网站标题|若网站标题为`某某有限公司`，那么标题可以输入`mm`（某某的拼音缩写）|
|网站域名|若网站域名为`abc.com`，那么域名可以输入`abc`或`abc.com`|
|姓名|若姓名为张三，那么姓名可以输入`zhangsan`，或者`zhang san`，输入内容带有空格时，程序会添加`ZhangSan`、`zhangsan`、`zs`、`ZS`|
|手机号|默认必须输入11位数字|
|生日|若选择的日期为2020-05-20，那么程序会添加`20200520`和`0520`|
|用户名|可以选择从某一用户名文件字典中添加|
|有序数列|输入一个有序数列的最小值和最大值，可以自动生成相应的数列(要求输入值的长度必须一致)，如`2010-2020`，`001-040`|
|自定义|可以根据实际需求手动添加字符到输入框中，输入框设计了右键菜单，可以对选中的字符进行反转追加等|

2. B类字符  
B类字符主要是符号，程序设计了两种选择，一种是程序自动生成符号组合，一种是配置文件`config.json`配置。  
符号组合如下图所示：  
![SymbolCombine](https://raw.githubusercontent.com/f1ashine/DictGenerator/master/img/symbols.png)  
通过设置`最大组合个数`来限制程序生成的符号数量，默认最大3种符号

3. C类字符  
通过配置文件`config.json`配置常见字符

## 0x03 其他
1. 考虑到用户在修改组合方式后，想下次接着使用该规则，因此设计了`保存配置`，便于即时保存用户自定义的字典组合方式

2. 考虑到配置文件`config.json`采用了json格式，在修改配置时可能难于复制粘贴，因此设计了`txt文件转json格式`按钮，便于通过打开一个txt字典文件，处理后显示在界面中：  
![txt2json](https://raw.githubusercontent.com/f1ashine/DictGenerator/master/img/txt2json.png)

3. 考虑到可能需要将生成的字典与其他字典合并的情况，设计了追加字典的功能，对于追加的字典进行了去重，生成的字典未另外设置去重。


