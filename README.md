# This is my Unity3D project
**Aiming at building a virtual garden, in which assign different tasks in different places, players are asked to complete these tasks**
**all the tasks are based on a storyline that is to help pler's family**
**once complete a task player will score 1**
**there are total 6 tasks**

## the *audio.cs* is the main script 

it handle the UI image and audio file(background music, collison audio effect), as well as some particle effect.

```
OnCollosionEnter(collison collsion)
{
if(gameObject.tag = "task")
destory()      -disappear the task object
}
```

## the other .cs script has the similar sturcture in audio.cs

these script works toghether to realize the whole function.


# Tips

the image i used are all set as the specifed format as the unity3d dont support outside format.

be careful on the collison component, select a suitable collision shape and try to make it only work to FPS collision.

the audio 3D effect can be set to make the volume of audio changable according to the distance.
