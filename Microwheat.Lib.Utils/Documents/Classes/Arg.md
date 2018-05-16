Arg
===

> 版本: 1.0.0.0

Arg 类是用于传递自定义数据的类。它继承自 `EventArgs`，并实现了范型。
定义的范型即为事件的自定义数据类型。

使用这个类，可以定义自定义的事件：`EventHandler<Arg<MyClass>>`。

这样即可以传递 `MyClass` 为数据的事件，在监听函数中获得 `MyClass` 数据。