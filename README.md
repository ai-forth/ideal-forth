## ideal-forth

An awesome way to get things done at the level of the machine. Here will be applying self-extension during runtime. Sure a _imperatively dangerous_ task, but who cares what people have said about this topic over the years. Look at the state of things!

A codebase to reflect the paradigm established by [Leo Brodie](https://www.forth.com/starting-forth/0-starting-forth/) in the 1981 book _Starting Forth_.

![gnu](/images/gnu-forth.png) ![swap](/images/swap-dragon.png)

### This distribution

The goal here is to establish a new paradigm for forth by echoing several goals:

* It should be a model, i.e. it should define all the implementation-dependent things.
* It should become standard, i.e. widely accepted and used. I proffer a robotic personality.
* Minimalist yet should provide for all the things that are considered necessary now and foresee what is on the horizon.
    - A predictive capability.
    - Anticipate.
    - Establish the paradigms of [ideal](https://github.com/cartheur/ideal).
* Be wickedly fast.    
* OOP. There's an object oriented [package](/releases/oof.zip), written in almost plain ANS Forth.

### Errata

* gforth Savannah [repo](https://git.savannah.gnu.org/cgit/gforth.git)
* GreenArrays [site](https://www.greenarraychips.com)
* Todo: Connect via WSL in windoze development environment

-----

## Getting interesting shit done

Use Wine in Debian Bookworm to run the sF development environment with access to the board. COMports in Linux are:

`dmesg | grep tty` where it will be seen:

```

[    0.000000] printk: console [tty0] enabled
[    1.225657] 0000:00:16.3: ttyS0 at I/O 0x4090 (irq = 17, base_baud = 115200) is a 16550A
[    5.077299] systemd[1]: Created slice system-getty.slice - Slice /system/getty.
[ 1129.168748] usb 4-1.2.3.2: FTDI USB Serial Device converter now attached to ttyUSB0
[ 1129.169615] usb 4-1.2.3.3: FTDI USB Serial Device converter now attached to ttyUSB1

```

When running the self-test routines in arrayForth, run this code from [here](https://wiki.winehq.org/index.php?title=Wine_User%27s_Guide&oldid=2519#Serial_and_Parallel_Ports):

`<COM> SELFTEST`

Added the keys to the registry, `wine regedit` maybe not right. So can investigate, but serial devices attached but not correctly mapped to Windows:

* `// ./COM16 PORT can't open it!`

Restart wine - `wineboot -r`

### See the samples

Brought over here from a MacOS 9.2.2 program, in a deep archive. A great place to get started with polyForth?

