import logging

# logging.warning('Watch out!') # will print a message to the console
# logging.info('I told you so') # will not print anything because the default level is set to WARNING

# Logging to a file
logging.basicConfig(filename='example.log', filemode='w', level=logging.DEBUG)
logging.debug('This message should go to the log file')
logging.info('So should this')
logging.warning('And this, too')

logging.warning('%s before you %s', 'Look', 'leap!')