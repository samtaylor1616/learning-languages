# Python Logging Examples

This sample is created during the [Python logging tutorial](hhttps://docs.python.org/3/howto/logging.html) for learning python.

## Key Features

- The Simple directory contains a basic logging example
- The Multiple directory contains logging from multiple modules

## Run

To run the sample, type the following command:

`python3 simple.py` in the Simple directory

# Basic Logging

- Logging is a means of tracking events that happen when some software runs
  - Add logging calls to code to indicate that certain events have occurred
  - An event is described by a descriptive message which can optionally contain variable data

## Logging Functions:

| Function                                                                      | Best use case                                                                                                                    |
| ----------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------- |
| print()                                                                       | Displaying console output for ordinary usage of a command line script or program                                                 |
| logging.info() or logging.debug() for detailed output for diagnostic purposes | Report events that occur during normal operation of a program (e.g. status monitoring or fault investigation)                    |
| warnings.warn()                                                               | Runtime event - In library code if the issue is avoidable and the client application should be modified to eliminate the warning |
| logging.warning()                                                             | Runtime event - If there is nothing the client application can do about the situation, but the event should still be noted       |
| Raise an exception                                                            | Report an error regarding a particular runtime event                                                                             |
| logging.error(), logging.exception(), or logging.critical()                   | Report suppression of an error without raising an exception                                                                      |

### Levels:

| Level    | Use case                                                                                                                                                           |
| -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| DEBUG    | Detailed information, typically of interest only when diagnosing problems                                                                                          |
| INFO     | Confirmation that things are working as expected                                                                                                                   |
| WARNING  | An indication that something unexpected happened, or indicative of some problem in the near future (eg. low disk space). The software is still working as expected |
| ERROR    | Due to a more serious problem, the software has not been able to perform some function                                                                             |
| CRITICAL | A serious error, indicating that the program itself may be unable to continue running                                                                              |
