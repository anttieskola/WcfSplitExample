# Description
This is just super simplified application showing
how to split WCF services into multiple ones.

The idea is to use ServiceKnownType attribute in
the interface definition. This allows the generated
clients on client side to use same object type as
without attribute the object types are different
between generated clients.

The client is kinda missing from code but it if
you create client from BookServiceOne and BookServiceTwo
the Book and Page types will be the same.