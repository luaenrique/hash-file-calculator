# hash-file-calculator

## Why is that useful?

In the field of Information Security there is a term called "Integrity". Integrity is the assurance that a given information is credible, authentic, reliable. It assures that a information will not be changed during transit between two communicators. And through this simple project is possible to know (using hash) if a file is the same as another one, checking its integrity.

## How it works?

A hash is basically a one-way function (it means that it is not reversible as cryptographic) that generates a fixed-length string based on input, in this case our input are files. A hash will always generate the same string for a same input data, that means that two different files would give us different hashes, in other words, a file should give us a specific hash and that hash can be compared to another one, if those hashes differ we got different files and a corrupted file.

## Example

So, I have created a .txt file with the content "hello everyone", the file was called test.txt. Then I have created two copies of that file "test(1).txt" and "test(2).txt". For test(1) I haven't made any changes, but for test(2) I put some "!!!!!" in the text. After that I have used my software to compare the test.txt with its copies.
You can check the result below:


(Comparing test.txt with test(1).txt)
![First Example](https://i.imgur.com/KlSHb1m.png)



(Comparing test.txt with test(2).txt)
![Second Example](https://i.imgur.com/vKUDuo4.png)
