PolishedToast
=======

Polished Android Toast for Xamarin


Usage
--------

```c#

PolishedToast.Info(this, "Info").Show(); // for blue background toast
PolishedToast.Success(this, "Success").Show(); // for greeen background toast
PolishedToast.Create(this, "Default").Show(); // for default toast
PolishedToast.Error(this, "Error").Show(); // for red background toast
PolishedToast.Warning(this, "Warning", ToastLength.Long, false).Show(); // for yellow background toast without icon and defined toast duration
```

Install
--------
Available on NuGet

[Nuget][Nuget]


License
--------

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

[Nuget]: https://www.nuget.org/packages/PolishedToast/
