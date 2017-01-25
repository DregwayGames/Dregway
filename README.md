# Dregway

A near-future dystopian turn-based roguelike.


###Level Design:

###Enemies:
Slightly dystopian allows for some slightly out-of-reality creatures

1. Silicates, Bots, androids, cyborgs, etc
2. Mutants, sewer dwellers, junkies, etc
3. Bulletpriests, hackers, etc
4. (Some) Enemies have own objectives: very slight element of plot generation - ie, some factions will dislike others, some enemies may be outcasts from factions, etc

###Equipment/items:
1. Powered suits - viable, but also dangerous
2. cell/stealth suits - short duration camo, basically entirely unprotected 
3. stim-suits: become some sort of speed, toxicity when damaged, etc
4. mechanized limbs/brain/etc - irreversible, but powerful - opens you up to hacking, degradation - doesn't heal normally
5. Smart grenades, scanning modules, molotovs, bows and javelins - should be able to mix and match pretty much anything here

###What makes it unique?


###Goal:


###"""Plot""":
* Burger King death squad sent into favella/slums/dregway or whatever to cleanse seditious elements from society


###Different Game Systems?
1. Turn based/scheduled combat system
2. Two effective actions (ie move -> shoot), but combat actions end turn (can't shoot -> move)
3. rules of game change based on equipment (ie: powered suits allow you to crush through most walls, jump to higher elevations/accross floor, etc - but also eliminate any element of surprise you could possibly have, and may become life-threatening when damaged)
4. Abilities are mostly equipment based - very little in the way of character progression
5. layered level system: high/low/mid elevation, etc
6. Plan route through undercity/dregway to visit specific nodes (missions are by selection, endresults are to be factored in: ie weapon dealers, etc)


---

##Roadmap
######Starting Out:

- [ ] basic movement/action
- [ ] async tile rendering
- [ ] async input handling
- [ ] empty levels
- [ ] basic sprites/spritesheets

#####Next steps:

- [ ] basic level generation
- [ ] basic elevation system
- [ ] nice sprites/spritesheets
- [ ] multiple actors at once


##Implementation Strategy

1. Seperate all rendering and input gathering from any game logic
2. Set up input/rendering in #define statements, so we can set the compile target for remote/local versions of the game
3. This should allow us to switch between local/remote versions just by changing the compile settings
 
### Using

1. Rendering/Input: https://github.com/craftworkgames/MonoGame.Extended
2. Communications: JSON serialization
3. Server: http://pomelo.netease.com/index.html or base C# (Figure this out later)
