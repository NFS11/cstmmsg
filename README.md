# cstmmsg
ctsmmsg is a tool written in C# and all it does is make custom error messages with some cool features

It has these features:

- Custom title
- Custom message
- Message, Error Message, Info Message and Critical Message.
- Compile to .exe
- Make it execute on startup (when compiling to .exe)

Is it safe?

Yes it is, but if you're using the .exe compiler and the startup feature you may get a threat detection since it uses custom compilation, adds entries to the Windows Startup registry and has an uncommon file signature which triggers some AV's. I will try to fix this issue in the next updates if I have time. But it is safe and triggers false positives.

I hope you enjoy using cstmmsg and make sure to leave a star if you liked my tool! Any issues or suggestions, post in the Issues tab.
