   M S B A M L   `   `   `  ????A  =Pract1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Pract1.ViewPract1.View  5   	   %    Pract1.View.AuthorizationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Pract1.View     5   	     ? Title$  AuthorizationWindow??5   	   $	??450??6%   $	??400??62   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $	??100 ?6   .+?5   
   ?? ???	#FF7F97B4$??0??6(   ?? 5   
   $??Авторизация??6   $??30(?6'   $??2??65   $??Center=?6I   
???????6f   ?? 5   
    ?? Orientation$ 
Horizontal=?6   $??1??6.   $??20q?6;   $??Center=?6G   $??Center=?6d   .+?5      ?? $ Vertical=?6   .+?5      ?? $??
Логин??6   $??20(?6)   $??20q?67   ?? 5      $??Пароль??6   $??20(?6*   $??10q?68   5      ?? 5      $ Vertical=?6   .+?5      ?? -   5         ??Name$ tbLogin??5      $	??200??6+   $??20(?67   $??22q?6E   G? 5      -   5         G?Name$ 
tbPassword??5      $	??200??62   $??20(?6>   5      5      ?? 5   
   -   5         ??Name$ btnRegistration??5      $??Регистрация??6*   $	??130??6@   $??30??6L   ???	#FF325885
???????$??15(?5   ;   $??2??6g   $??	0 0 200 0q?5       ?? 5!   
   -   5        $ 	btnSignIn??5!      $??
Войти??6$   $	??130??64   $??30??6@   ???	#FF325885
???????$??15(?5"   ;   $??2??6a   $??	200 0 0 0q?5#      5$      5%      