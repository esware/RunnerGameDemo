# RunnerGameDemo
This project was made for computer games and simulation course.


![image](https://user-images.githubusercontent.com/48649947/218386551-57285424-c151-4641-9361-509f69e17947.png)
![image](https://user-images.githubusercontent.com/48649947/218386614-cfcce767-6b74-46a0-987b-bc412386baaf.png)
![image](https://user-images.githubusercontent.com/48649947/218386653-8f18680b-5355-41fa-9a7c-75dfa8255782.png)
![image](https://user-images.githubusercontent.com/48649947/218386791-c8e4db15-3a5c-4fa5-b770-95c84332e307.png)

Animation-based finite state machine was used in this project, our character's animations such as jump, idle, running are running their own codes, so I aimed to prevent unnecessary update calls and performance problems on mobile devices.

Statedata is a class of scriptable objects and represents a state, our class characterStateBase maintains a list of statedata so I can run multiple states in one animation.

![image](https://user-images.githubusercontent.com/48649947/218387009-01e40a10-1276-474d-a866-4f7db898861f.png)
![image](https://user-images.githubusercontent.com/48649947/218387316-aab6fd79-211d-47d9-8440-feaaed3e422f.png)
