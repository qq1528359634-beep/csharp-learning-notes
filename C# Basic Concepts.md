
<h1>C#之路</h1>
二进制负数转化，符号位不变其余位取反再加1

ConsoleApp 独立可以运行 有Main方法 生成exe\
ClassLibrary 不可以独立运行 无Main方法 生成dll 需要被其他项目引用

实例方法  写在类内部 通过实例来调用\
*例：汽车（实例）可以跑 图纸（类）不能跑*\
静态方法  写在类内部 通过类调用\
*例：图纸（类）可以折叠 汽车（实例）不能折叠*\
拓展方法  写在外部类  是后来贴上去的静态方法\
*例：给我一个对象 可以是汽车图纸（类）也可以是汽车（实例），我给他贴上一个标签，可以通过着对象来访问并使用这个标签*

<details close>
<summary>类库的依赖</summary>
&emsp;如果一个类库A依赖了其它类库B和C，则引用这个类库A的同时就是依赖了类库B和C
	
例：A部品上装B和C部品，此时给主体（汽车）装上A部品 就相当于装上了B和C部品
</details>

<h2>委托</h2>
<details close>
<summary>什么是委托</summary>
&emsp;委托是引用类型，委托类型的实例可以挂载方法，定义一个委托类型相当于规定了什么样的方法可以挂载在委托实例上。
通过=给委托对象赋初始值，通过+=追加挂载方法，-=移除已挂载的方法。
</details>
<details close>
<summary>调用委托实例</summary>
&emsp;调用委托实例等于调用挂载在委托实例上的方法。
</details>


签名
方法名 + 参数列表（数量、顺序、类型）

<h2>事件</h2>
<details close>
<summary>事件的5要素</summary>
	<li>事件的拥有者: 拥有事件成员的类</li>
	<li>事件成员: 通过event定义的类中成员，用于挂载事件响应器</li>
	<li>事件响应者: 事件处理器（回调方法）所在的类</li>
	<li>事件处理器: 当事件触发时会调用挂载在事件上的事件处理器</li>
	<li>事件订阅: 将事件处理器 挂载在事件上</li>
	<br><i>事件拥有者声明事件，事件的响应者将自己的事件处理器挂载在事件上，当事件被触发，调用所有挂载在事件上的事件处理器.</i><br\>
</details>
<details close>
<summary>事件的调用</summary>
事件成员只能出现在+=或-=符号的左侧，以及声明事件的类内部
</details>

<h2>转化</h2>
<details close>
<summary>什么是转化</summary>
声明2个不同类型的变量，将一个变量（源）的值赋值给另外一个变量（目标）
</details>
		
<details close>
<summary>隐式转化</summary>
 不会丢失数据或者精度，能默认进行转化
 <br><i>ex:子类转父类，接口的实现类转接口,任何类型转object，int转long</i><br\>
</details>

<details close>
<summary>显式转化</summary>
 有丢失数据或者精度，或报错的风险需要强制转化表达式
 <br><i>ex:父类转子类，long转int</i><br\>
</details>

<details close>
<summary>溢出检测</summary>
<li>check:int a=check((int)longNumber); 如果值溢出就抛出OverflowException异常
<li>uncheck：int a=check((int)longNumber); 值溢也不报错
<br><i>check和uncheck只管整数溢出，不作用于引用类型或浮点型</i><br\>

