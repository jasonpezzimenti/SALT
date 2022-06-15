# SALT
```smalltalk
-> {
  out with "Please enter your name.", expect input {
    string name: Console.Input;
    out with "Hello, " + name + ".";
  }
}
```

Output:
```
Hello, Jason.
```
