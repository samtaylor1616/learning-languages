# C# LINQ

This sample is created during the [Work with Language-Integrated Query (LINQ)](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq).

## Application - Faro Shuffle

- The faro shuffle is a technique where you split a card deck exactly in half, then the shuffle interleaves each one card from each half to rebuild the original deck.
- Magicians use this technique because every card is in a known location after each shuffle, the order is a repeating pattern.

The application constructs a card deck and then performs a sequence of shuffles, writing the sequence out each time.

## Key Features & Learning Take Aways

- Using LINQ queires to aggregate data into meaningful sequences
- Write Extension methods to add our own custome functionality to LINQ queries
- Locating areas in our code where our LINQ queries might run into performance issues like degraded speed
- Distinguish between eager and lazy evaluation in regards to LINQ queries and the implications they might have on query performance

### Caching

- To cache the deck of cards, leverage the LINQ methods ToArray and ToList;
- When you append them to the queries, they'll perform the same actions as told, but now they'll store the results in an array or a list, depending on which method you choose to call.

## Build and Run

To build and run the sample, type the following command:

`dotnet run`
