# Formation interne: Presentation des ORM

 Nicolas Anderlini
 10 septembre 2024
  
 Team Forfait Codebusters

 Presentation du principe des ORM avec exemple EF/Postgres en .net core


# Content

## Whats an ORM
__Goal__

Object-Relational Mapping (ORM) is a programming technique that facilitates the interaction between a relational database and a programming language. It acts as a bridge between the logical, object-oriented representation of data in the code and the physical, relational structure in a database.


__Request Generation__

It translate code action into sql requests. The connector gives the implementation for the chosen DB. 
Depending on which database is used, requests translate differently and allow using limited and/or different action from code.

_You have to understand how the underlying layer works (the database) to be able to dig into the request generation. The database leads what the code can do and how it can do it, never the opposite._

__Mapping and Tracker__

It maps request result into program object instances.
Capable of managing two way mapping, potentially attached mode.
Tracker keep tabs on these instances.

_Mapping come inherently with a computing cost, and a **lot** more in attached mode_

_You can map a lot more than tables, colums and row, ex trigger or procedures_

## EF
__Configuration__

Configuring EF is tuning how the request generation and the mapping is handled.

_Configuration by code / Configuration by annotation_

Configuration by code => Allow to keep entities clean. Specialize classes, it's more SOLID.
Configuration by annotation => More readable, but at the cost of heavy description code inside entities.

__Database generation / Database first__

EF allow you create a database (and managing "migrations") or directly plug to a existing database.

__Entities, Context and Repositories__

The entities represents sets of value in the database.

Context manage "everything". It's the link between the running DB and the entities.

The repositories, if needed, allow you to specializes database requests and mapping.

__Linq and IQueryable__

IQueryable is not IEnumerable, but...

EQueryable Sets from table _or view_.
Create, Read, Update and Delete (CRUD) is a given with an ORM.

_detached mode => better performance, more specialized requests_
_attached mode => less work to "reattach", less work to look into related tables_

Lazy/Eager

Note: Performance with indexes.

__Repository and Specialized requests__

Difference between detached and attached mode from repository view.

Circle references problems

Locks and transactions

__Conflicts, or the Versionning and how to avoid it__

The problem of attached mode and long requests
Solution: Detached.

The problem if detached mode but no versionning
Solution: We check the version when we reattach. Version is incremented.

## Final Notes and Caveats

Proxy and the infinite requests

Migrations and existing data

ORM come with a computing cost. Micro-ORM without extended function or attached mode can be a interresting alternative.

Detached mode and the join nightmare


# Pros and Cons

Can't do better than:
https://stackoverflow.com/questions/1279613/what-is-an-orm-how-does-it-work-and-how-should-i-use-one

Using ORM saves a lot of time because:

DRY: You write your data model in only one place, and it's easier to update, maintain, and reuse the code.
A lot of stuff is done automatically, from database handling to I18N.
It forces you to write MVC code, which, in the end, makes your code a little cleaner.
You don't have to write poorly-formed SQL (most Web programmers really suck at it, because SQL is treated like a "sub" language, when in reality it's a very powerful and complex one).
Sanitizing; using prepared statements or transactions are as easy as calling a method.

Using an ORM library is more flexible because:

It fits in your natural way of coding (it's your language!).
It abstracts the DB system, so you can change it whenever you want.
The model is weakly bound to the rest of the application, so you can change it or use it anywhere else.
It lets you use OOP goodness like data inheritance without a headache.

But ORM can be a pain:

You have to learn it, and ORM libraries are not lightweight tools;
You have to set it up. Same problem.
Performance is OK for usual queries, but a SQL master will always do better with his own SQL for big projects. (Note nico: but TESTS)
It abstracts the DB. While it's OK if you know what's happening behind the scene, it's a trap for new programmers that can write very greedy statements, like a heavy hit in a for loop.
