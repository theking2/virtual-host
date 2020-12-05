# virtual-host
A c# desktop program to easily generate and add virtual hosts to *any* Apache server (mamp, xampp, ...)

## what?
In order to work on multiple web projects local(host)ly it is beneficial to have a separate hostname for each project. Thereby there is no awkward surplus root folders that might mess up or complicate deployment. This can be done by enabling virtual hosts in apache conf and create and add ""VirtualHost"" sections in vhost.conf

## so what?
Noone really whants to get bothered with the antiquated and cumbersome syntax of Apache config files. You can browse the web to find how this works but that also is cumbersome and result is error prone. Also on Windows the hosts file is tucked away nicely where nobody can find it (thank you Microsoft!)

## no what?
This little program takes away the cumbersomeness of creating and activating VirtualHosts entries and at the sametime maintains the /etc/hosts file. It is as easy as dragging and dropping a folder to a desktop icon, typing a hostname, and paste the setup to a vhost.conf file of your liking.

## What it does not
* Find out what flavour of wamp you are running.
* Locate the proper location of the vhost.conf
* Cleanup after you've done with your vhost. If you need to remove a vhost, manual editing is required.
* Automatically stop and start Apache, or readin the hosts file (you will need wampserver64 for that)

## What it does
* Create a vhost section and put it on the clipbboard ready for pasting
* Create an entry in the Windows /etc/hosts file (admin rights required!)

# How to use
For all usages it is important that vhosts is activated in Apache, wampp has this, mamp not. 

## Usage 1
* Copy the exe file to a location you can easily, for instance the desktop.
* Richt click the exe and make sure that Run as Administrator is activated in Compatibility settings
* Drag and drop a folder on the exe, accept UAC, type a name, open the vhosts.conf and paste the contents of the clipboard to the end of thee file
* Restart Apache

## Usage 2
* Copy the exe file to a location you can easily, for instance the desktop.
* Create a registry entry like:

> Windows Registry Editor Version 5.00
> [HKEY_CLASSES_ROOT\Directory\shell\AddVIrtualHost]
> @="Add this as Apache vhost"
>
> [HKEY_CLASSES_ROOT\Directory\shell\AddVIrtualHost\command]
> @="\"path to virtualhost\\VirtualHost.exe\" \"%1\""

* Right click a folder and select Add


