## ideal-forth

A codebase to reflect the paradigm established by [Leo Brodie](https://www.forth.com/starting-forth/0-starting-forth/) in the 1981 book _Starting Forth_.

![gnu](/images/gnu-forth.png) ![swap](/images/swap-dragon.png)

### Why?

When completing both the ideal algorithm in C# _and_ taking the time to understand M6809-multicomputer, it seems wise to have a look at this language and see if it can help solve bottlenecks with aiventure-david, now _joi_. Can't say it here, but see its evolution called [five](https://github.com/cartheur/ideal-five).

### This distribution

The goal of the forth is to advance an evolving model for ANSI Forth. This code adheres to several goals:

* Forth should conform to the ANSI/200x Forth standard.
* It should be a model, i.e. it should define all the implementation-dependent things.
* It should become standard, i.e. widely accepted and used. This goal is the most difficult one.
* To achieve these goals Gforth should be
    - Similar to previous models (fig-Forth, F83)
    - Powerful. It should provide for all the things that are considered necessary today and even some that are not yet considered necessary.
    - Efficient. It should not get the reputation of being exceptionally slow.
    - Open source.
    - Available on many machines/easy to port.
* There's an object oriented [package](/releases/oof.zip), written in almost plain ANS Forth, now a part of this distribution.