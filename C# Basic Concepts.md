
ConsoleApp 独立可以运行 有Main方法 生成exe\
ClassLibrary 不可以独立运行 无Main方法 生成dll 需要被其他项目引用

实例方法  写在类内部 通过实例来调用\
*例：汽车（实例）可以跑 图纸（类）不能跑*\
静态方法  写在类内部 通过类调用\
*例：图纸（类）可以折叠 汽车（实例）不能折叠*\
拓展方法  写在外部类  是后来贴上去的静态方法\
*例：给我一个对象 可以是汽车图纸（类）也可以是汽车（实例），我给他贴上一个标签，可以通过着对象来访问并使用这个标签*

<details open>
<summary>类库的依赖</summary>
如果一个类库A依赖了其它类库B和C，则引用这个类库A的同时就是依赖了类库B和C
	
例：A部品上装B和C部品，此时给主体（汽车）装上A部品 就相当于装上了B和C部品
</details>

<details open>
<summary>委托</summary>
</details>

签名
方法名 + 参数列表（数量、顺序、类型）

## 事件
<details open>
<summary>事件的5要素</summary>
	<li>1.订阅者: 订阅事件并提供事件的处理方法 +=订阅事件</li>
	<li>2.发布者: 负责事件触发的逻辑</li>
	<li>3.委托: 定义响应事件的方法的签名（参数列表+返回值）</li>
	<li>4.事件: 当事件被触发时，调用所有订阅者注册的方法</li>
	<li>5.数据: 通过事件传递给订阅者的信息</li>
	
</details>
<details open>
<summary>.事件的调用</summary>
事件成员只能出现在+=或-=符号的左侧，以及声明事件的类内部
</details>

1. First list item
   <details open>
   - <summary>First nested list item</summary>
   </details>
     - Second nested list item
