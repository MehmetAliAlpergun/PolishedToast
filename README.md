PolishedToast
=======

Polished Android Toast for Xamarin

Screens
--------

![screen](https://github.com/MehmetAliAlpergun/PolishedToast/blob/master/Screens/success.png)
![screen](https://github.com/MehmetAliAlpergun/PolishedToast/blob/master/Screens/error.png)
![screen](https://github.com/MehmetAliAlpergun/PolishedToast/blob/master/Screens/info.png)
![screen](https://github.com/MehmetAliAlpergun/PolishedToast/blob/master/Screens/warning.png)
![screen](https://github.com/MehmetAliAlpergun/PolishedToast/blob/master/Screens/default.png)


Usage
--------

```c#

// for blue background toast with info icon
PolishedToast.Info(this, "Info").Show(); 

// for greeen background toast with success icon
PolishedToast.Success(this, "Success").Show(); 

// for grey background toast without icon
PolishedToast.Create(this, "Default").Show(); 

// for red background toast with error icon
PolishedToast.Error(this, "Error").Show(); 

// for yellow background toast without icon and defined toast duration
PolishedToast.Warning(this, "Warning", ToastLength.Long, false).Show(); 

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
