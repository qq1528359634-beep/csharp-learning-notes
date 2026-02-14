
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
	<li>括号强转，as转化
	 <br><i>括号强转失败抛出异常，as转化失败返回null</i><br\>
</details>

<details close>
<summary>溢出检测</summary>
	<li>check:int a=check((int)longNumber); 如果值溢出就抛出OverflowException异常</li>
	<li>uncheck：int a=check((int)longNumber); 值溢也不报错</li>
	<br><i>check和uncheck只管整数溢出，不作用于引用类型或浮点型</i><br\>
</details>

<details close>
<summary>is 运算符</summary>
	如果类型A能够在运行期间成功转化为B则返回true，否则返回false
	<br>只用于引用类型的转化，不可用于值类型和自定义转化类型<br\>
</details>


<h2>泛型</h2>
<details close>
<summary>协变 逆变</summary>
	<li>协变：将一个返回子类的方法，当作返回基类的方法使用。</li>
	<li>逆变：将一个传入父类，处理父类的方法，当作处理子类的方法使用。</li>
</details>


<h2>依赖倒置 控制反转 依赖注入</h2>
<details close>
<summary>依赖倒置（原则）</summary>
	传统模式中高层模块依赖于底层实现，依赖反转中将高层模块定义接口，让底层模块负责实现这个接口。
	高层模块不再依赖于底层，而底层依赖于抽象接口（需要实现该接口），依赖关系反转了。
</details>
<details close>
<summary>控制反转（模式）</summary>
	不再对象内部创建依赖对象,只是提出需求，由外部提供依赖对象。
</details>
<details close>
<summary>依赖注入（技术）</summary>
	控制反转的具体实现技术，C#常在构造函数中注入依赖
	但是注入依赖是若使用对象实例，而非接口实例的只能是控制反转而非依赖倒置
</details>

<details close>
<summary>综合比喻</summary>
	<li>传统模式</li>
	<i>我需要一双筷子 我自己做一双竹筷子，我只能使用这双竹筷子</i>
	<li>控制反转</li> 
	<i>我要一双筷子 我去百货店和店员说 请给我 一双竹筷子 ，店员给我一双竹筷子，我只能这双竹筷子但是我不用自己去做了。</i>
	<li>控制反转+依赖倒置</li>  
	<i>我要一双筷子  我去百货店和店员说给我一双筷子，只要是筷子就可以
（将竹筷子抽象成筷子（将请求的具体对象改成抽象接口）），店员给我一双不锈钢筷子，我一样能使用这双筷子。</i>
</details>
