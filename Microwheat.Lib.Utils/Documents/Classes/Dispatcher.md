Dispatcher
==========

> 版本: 1.0.0.0

Dispatcher 用于发送事件。

用 Dispatcher 发送事件。有两大类种静态方式：

1. 直接使用 Dispatcher 类

> * `Dispatcher.Dispatch(eventHandler, sender);` 用于发送无参数的事件。
> * `Dispatcher.Dispatch(eventHandler<EventArgs>, sender, eventArgs);` 用于发送以 eventArgs 为数据的事件。
> * `Dispatcher.Dispatch(eventHandler<Arg<MyClass>>, sender, myClass);` 用于发送以 Arg<Myclass> 为数据的事件。

2. 使用扩展方法

> * `eventHandler.Dispatch(sender);` 用于发送无参数的事件。
> * `eventHandler<EventArgs>.Dispatch(sender, eventArgs);` 用于发送以 eventArgs 为数据的事件。
> * `eventHandler<Arg<MyClass>>.Dispatch(sender, myClass);` 用于发送以 Arg<Myclass> 为数据的事件。
