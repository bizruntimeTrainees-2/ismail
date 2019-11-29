enum LogLevel {
    ERROR, WARN, INFO, DEBUG
}

type LogLevelStrings = keyof typeof LogLevel;

function printErrors(key: LogLevelStrings, message: string) {
    const num = LogLevel[key];
    if (num <= LogLevel.WARN) {
       console.log("Log level key is: "+ key);
       console.log("Log level value is: "+ num);
       console.log("Log level message is: "+ message);
    }
}
printErrors('INFO', 'This is a message');