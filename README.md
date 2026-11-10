# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
camera will keep staying when cat is walking.
https://donghul8-code.itch.io/inclassproject1

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1 because they are decimals ranged from 0.0 to 1.0. Not integer word or true or false.
2 because the number of bounces can only be integer.
3 it loses ";", without it coding cannot work.

### W3
activity1 
1. parameters: float/bool return type: string
2. parameters: float 
3. parameters: float return type: bool

activity2
1.classes are different blueprints of a car, and components are the real parts of a car encoutering the different blueprints. member varaibles are different components, and methods are the functions they can do.

activity3
1.because the value of color is growing exponentially.

### W4
-table7
1. I added rigidbodies to cat and soccerball and goal is trigger on.
2. When I tested first, the time showed always 0000...016, and I found the reason is I wrote wrong code timer = Timedelta.Time, so it only showed time of every frame. Then I corrected it to timer += Timedelta.Time, it worked as timing.

### W5
1. this class need a variable to store Deer's target object. a transform variable can perfectly fit this requirement. And also a NavMeshAgent variable to access Deer's NavMeshAgent component.
2. It needs Start() for static object and Update() for dynamic object. Because, for static one, after telling deer where to go first time, deer will go to there and stay at that position, but for dynamic one, deer is always walking during gameplay and destination is always updated. 
3. this method let Deer walk to the destination by AI navigation system.

### W6
-planning
1. Bat follows the player.
2. Add speed.
3. Start chasing.
4. Stop chasing.
5. Check player distance.
6. Add bat messages.
7. Store messages in an array.
8. Pick random messages.
9. Add a timer for messages.
10. Stop chasing when the player is too far away.
-https://docs.google.com/document/d/1crDX6_ljdbrT8OOdQbNwN7QxS_CrQY8VUW1fGK32XYQ/edit?tab=t.td22qoj399or

#
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
