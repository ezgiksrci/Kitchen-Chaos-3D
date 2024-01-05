<a name="readme-top"></a>

<div align="center">
	
![KitchenChaosIcon](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/ac4ba53a-d01f-495c-b0e0-f146ba49994e)
  

**🇹🇷** Kitchen Chaos; oyuncunun verilen süre içerisinde, ekrandaki rastgele yemek tariflerini doğru bir şekilde teslim etmesi gereken *Overcooked* benzeri **Single Player bir 3D Unity** oyunudur.

**🇪🇳** Kitchen Chaos is a Single-Player 3D Unity game similar to Overcooked, where the player must correctly deliver random recipe orders on the screen within a given time.

### Gameplay GIF

![Gameplay_GIF](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/cc95fe1c-5b41-49aa-ae5d-7ad5c872dc42)


### Gameplay Video

https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/fbb8de7c-d84b-4784-9a32-e04d26eb39e4


</div>
 
----------
<!-- TABLE OF SECTIONS -->
  # Sections
  <ol>
	  <li><a href="#Introduction">Introduction</a></li>
	  <li><a href="#Lessons-Learned">Lessons Learned</a></li>
	  <li><a href="#Game-Scenes">Game Scenes</a></li>
	  <li><a href="#Tools-and-Technologies">Tools and Technologies</a></li>
	  <li><a href="#Releases">Releases</a></li>
	  <li><a href="#Roadmap">Roadmap</a></li>
	  <li><a href="#Acknowledgements">Acknowledgements</a></li>
  </ol>

----------

<!-- INTRODUCTION -->
## Introduction

**🇹🇷** Bu proje, [Code Monkey](https://www.youtube.com/watch?v=AmGSEH7QcDg&t=21415s) dersinin uygulamasını içermektedir. Bu dersle birlikte Unity ile oyun geliştirirken gerekli olan <u>*temel ve ileri seviye*</u> ***Unity, Game Design Patterns, C#, Clean Code, SOLID Principles*** gibi birçok önemli concepti uygulamalı olarak öğrenme ve deneme fırsatı edindim.  

**🇪🇳** This project includes the implementation of the [Code Monkey](https://www.youtube.com/watch?v=AmGSEH7QcDg&t=21415s) tutorial. Alongside this tutorial, I had the opportunity to learn and practice <u>*essential and advanced*</u> concepts in Unity game development, such as ***Unity, Game Design Patterns, C#, Clean Code, and SOLID Principles***, in a hands-on manner. 


|  <u>*The **Concepts** I Learned and Applied with this Course:*</u>
| ------------- 
|	:heavy_check_mark: Naming Rules
|	:heavy_check_mark: Unity Layout
|	:heavy_check_mark: Unity Execution Order
|	:heavy_check_mark: URP
|	:heavy_check_mark: Post Processing (Color Correction, Bloom, Vignette, Screen Space Ambient Occlusion and Anti-Aliasing)
|	:heavy_check_mark: Particles
|	:heavy_check_mark: Lerp / Slerp
|	:heavy_check_mark: Animation System
|	:heavy_check_mark: Cinemachine
|	:heavy_check_mark: New Input System (Keyboard + Mouse / Gamepad)
|	:heavy_check_mark: Input Rebinding
|	:heavy_check_mark: Character Controller
|	:heavy_check_mark: Collisions and Interactions
|	:heavy_check_mark: Raycast, Capsule Cast
|	:heavy_check_mark: Unity Layers, LayerMask
|	:heavy_check_mark: Unity Prefabs
|	:heavy_check_mark: Enums
|	:heavy_check_mark: Delegates, Actions, C# Events, EventHandlers
|	:heavy_check_mark: Statics
|	:heavy_check_mark: Singleton Pattern
|	:heavy_check_mark: Scriptable Object
|	:heavy_check_mark: Inheritance
|	:heavy_check_mark: Interfaces
|	:heavy_check_mark: Generics
|	:heavy_check_mark: Structs
|	:heavy_check_mark: Canvas, UI (Menu UI, Fail / Succes UI, Progress Bar UI etc.)
|	:heavy_check_mark: State Machine
|	:heavy_check_mark: Shader Graph
|	:heavy_check_mark: Audio Source, Audio Clips
|	:heavy_check_mark: Scene Loading
|	:heavy_check_mark: Game Pause
|	:heavy_check_mark: Player Prefs (Data Saving)  

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LESSONS -->
## Lessons Learned

<details>
<summary><h3> Bu projeyle birlikte öğrendiklerimi daha detaylı okumak için tıklayınız: </h3></summary>

Bu projedeki oyun geliştirme serüvenim, çeşitli konuları içererek hem teknik hem de yaratıcı becerilerimi geliştirmeme olanak sağladı. Daha önceden bildiğim ama uygulama fırsatı bulamadığım önemli OOP konseptlerini, Game Development Design Pattern'lerini ve Unity'deki Tool'ları kullanma imkanı buldum.

#### *1. İsimlendirme Kuralları (Naming Rules):*
Proje içindeki değişken, fonksiyon ve nesneleri uygun bir şekilde adlandırma konusundaki önemi öğrendim. Bu, kodun anlaşılırlığını artırıp ve işbirliğine uygunluğu sağladı.

#### *2. Unity Layout:*
Unity'nin kullanıcı arayüzünü efektif bir şekilde kullanmayı öğrenerek, projelerimi daha düzenli ve erişilebilir hale getirdim. Bu, çalışma verimliliğimi artırdı.

#### *3. Unity Execution Order:*
Oyun nesnelerinin işlem sırasını anlamak, oyun mekaniğimi daha iyi kontrol etmemi sağladı. Bu, düzgün bir oyun akışı oluşturmamı sağladı. Execution Order'ın oyun geliştirmede ne kadar yararlı olduğunu ama aynı zamanda dikkat edilmezse çok kolay hataya sebebiyet verebileceğini anladım.

#### *4. URP (Universal Render Pipeline):*
URP kullanarak, oyunumun grafik kalitesini artırma ve performansı optimize etme yeteneği kazandım.

#### *5. Post Processing Effects:*
Color Correction, Bloom, Vignette, Screen Space Ambient Occulusion ve Anti-Aliasing gibi post proccessing efektlerini kullanarak, oyunun atmosferini ve görsel çekiciliğini iyileştirdim.

#### *6. Particle System ve Animation System:*
Unity'nin Particle System ve Animation System'ini kullanarak, yaptığım oyundaki dünyayı canlandırmak ve daha etkileyici bir deneyim sunmak konusunda beceri kazandım.
- Player'ın yürüme durumunda ve ocakta et pişme durumunda tetiklenen particle effectler kullandım. Aynı zamanda Player'a Walking ve Idle animasyonu, yemek malzemelerinini kesme animasyonu gibi animasyonlar ekleyerek Animation System'i sıkça kullandım.

#### *7. New Input System & Input Rebinding:*
Klavye, fare ve gamepad gibi farklı giriş cihazlarını etkili bir şekilde yönetme yeteneği kazandım. New Input System sayesinde oyuna farklı input destekleri kazandırmanın ne kadar kolay olduğunu gördüm.

#### *8. Cinemachine*
Unity'nin bu aracı sayesinde kamera kontrolünü optimize etmeyi ve oyun içinde etkileyici görsel deneyimler oluşturmayı öğrendim. Cinemachine sayesinde; kamera takibi, zoom, yandan bakış gibi birçok özelliği basitleştirerek karmaşık kamera sistemleri kolayca oluşturabileceğimi ve yönetebileceğimi anladım.

#### *9. Character Controller:*
Character Controller kullanarak, oyuncu karakterimin hareketini ve etkileşimlerini daha doğru bir şekilde yönetme becerisi kazandım. Bunu yaparken input dinleyerek gelen input Vector'unu kullanarak transform ile Player'ın hareket etmesini sağladım.

#### *10. Collisions and Interactions:*
Collisions and Interactions konusunda derinlemesine bilgi edindim. Bu, oyun dünyamda daha gerçekçi ve dinamik etkileşimler oluşturmama yardımcı oldu.

#### *11. Raycast, Capsule Cast:*
Fizik tabanlı etkileşimlerde ve çarpışma algılamada kullanılan raycasting ve capsule casting tekniklerini öğrenerek, nesneler arası etkileşimlerimi daha hassas bir hale getirdim. Eskiden kullandığım OnCollisionEnter, OnTriggerEnter gibi yapılar yerine CapsuleCast ve RayCast gibi yapıların çok daha esnek ve performans yönünden faydalı olduğunu anladım. Bu nedenle gerektiği yerlerde OnCollisionEnter, gerektiğinde de RayCast gibi yapıların kullanılmaya karar verdim.  

#### *12. Unity Layers, LayerMask:*
Oyun nesnelerini ve etkileşimlerini katmanlar aracılığıyla düzenleyerek, performansı artırma ve karmaşık sahneleri daha iyi yönetme yeteneği kazandım.

#### *13. Unity Prefab'leri ve Enum'lar:*
Prefab ve enum kullanarak, oyun nesnelerini daha verimli bir şekilde oluşturmayı ve yönetmeyi öğrendim.

#### *14. Delegates, Actions, C# Events, EventHandlers:*
Delegate ve event kullanarak, oyun içindeki olayları etkili bir şekilde yönetmeyi ve kodumun daha modüler olmasını sağlamayı öğrendim.

#### *15. Singleton Design Pattern ve Statics:*
Singleton ve Static yapıları sayesinde, verileri paylaşma ve tek bir örnek üzerinden erişim sağlama yetenekleri kazandım.

#### *16. Scriptable Object:*
Scriptable Object kullanımı ile oyun verilerini daha esnek bir şekilde düzenleyebilme ve sürdürülebilirliği artırma konusunda deneyim kazandım.

#### *17. Inheritance ve Interfaces:*
Sınıflar arasında kodun paylaşılmasını sağlayarak ve farklı nesnelerin ortak davranışlarını tanımlayarak, kodumu daha organize hale getirdim. Böylece kod hem daha anlaşılır hem de refactor edilmeye daha müsait ve modüler bir hal aldı. Proje büyüdükçe, kod yapısının bu şekilde tasarlanmasının aslında projenin Spaghetti Code yapısına bürünmemesi açısından ne kadar önemli olduğunu anladım.

#### *18. Generics ve Structs:*
Generics kullanarak daha esnek veri yapıları oluşturma yeteneği kazandım. Ayrıca, Class yapısı yerine daha hafif ve performans odaklı Struct yapısının kullanımını öğrenerek, kod verimliliğimi artırdım.

#### *19. Canvas, UI (Menu UI, Fail / Success UI, Progress Bar UI, vb.):*
UI tasarımı ve implementasyonunda Canvas kullanımıyla, kullanıcı arayüzünü daha çekici ve kullanıcı dostu bir hale getirme yeteneği kazandım. UI elemanlarının kullanıcının ekranına göre uyum sağlayabilir bir yapıda olmasını sağladım.

#### *20. State Machine Design Pattern:*
State machine kullanarak, oyun karakterinin farklı durumlar arasında geçiş yapmasını ve davranışlarını düzenlemeyi öğrendim. Bu, oyun karakterinin daha modüler ve kontrol edilebilir olmasını sağladı.

#### *21. Shader Graph:*
Shader Graph kullanarak, özel görüntü efektleri oluşturmayı ve oyunun görsel estetiğini artırmayı öğrendim. Oyundaki Delivery Counter'ın üzerindeki ok işaretinin hareketli olmasını sağladım ve farkettim ki ShaderGraph'ler çok kullanışlı ve eğlenceli yapılar.

#### *22. Audio Source, Audio Clips:*
Unity'nin audio sistemi ile Audio Source ve Audio Clipleri yönetmeyi öğrenerek, oyun atmosferini zenginleştirmeyi başardım. Aynı zamanda menüye ses kontrol arayüzü de ekleyerek kullanıcıya ses seviyelerini ayarlama imkanı sağladım.

#### *23. Scene Loading:*
Sahneler arası geçişleri yöneterek, oyun içinde farklı bölümleri etkili bir şekilde yüklemeyi ve yönetmeyi öğrendim.

#### *24. Game Pause:*
Oyunun duraklatma mekanizmasını oluşturarak, kullanıcıya daha iyi bir oyun kontrolü sağlamayı öğrendim.

#### *25. Player Prefs (Data Saving):*
PlayerPrefs kullanarak oyun verilerini saklamayı ve kullanıcı ilerlemesini kaydetmeyi öğrenerek, oyunun sürekli bir deneyim sunmasını sağladım.

</details>

----------

<details>
<summary><h3>What I Learned With This Project. If you want to read the details please click here: </h3></summary>
	
My game development journey in this project has provided the opportunity to enhance both technical and creative skills, covering various aspects. I had the chance to apply essential OOP concepts, and game development design patterns, and utilize Unity tools that I previously knew but hadn't implemented. This project allowed me to apply and solidify these skills, contributing to a well-rounded game development expertise.

#### *1. Naming Rules:*
Learned the importance of appropriately naming variables, functions, and objects in the project, enhancing code readability and collaboration.

#### *2. Unity Layout:*
Mastered effective use of Unity's user interface, creating more organized and accessible projects, thereby improving workflow efficiency.

#### *3. Unity Execution Order:*
Understanding the processing order of game objects facilitated better control of game mechanics, ensuring a smooth game flow.

#### *4. URP (Universal Render Pipeline):*
Gained the ability to enhance graphic quality and optimize performance using URP.

#### *5. Post Processing Effects:*
Improved the game's atmosphere and visual appeal through the use of post-processing effects like Color Correction, Bloom, Vignette, Screen Space Ambient Occlusion, and Anti-Aliasing.

#### *6. Particle System and Animation System:*
Utilized Unity's Particle System and Animation System to bring the game world to life, creating a more immersive experience.

#### *7. New Input System & Input Rebinding:*
Effectively managed different input devices, such as keyboard, mouse, and gamepad, enhancing the game's accessibility. The New Input System provided an easy way to add various input support to the game.

#### *8. Cinemachine:*
Learned to optimize camera control and create impressive visual experiences using Unity's Cinemachine tool, simplifying complex camera systems.

#### *9. Character Controller:*
Acquired the skill to precisely manage the movement and interactions of the player character using the Character Controller.

#### *10. Collisions and Interactions:*
Deepened knowledge in handling collisions and interactions, creating more realistic and dynamic in-game experiences.

#### *11. Raycast, Capsule Cast:*
Learned to use raycasting and capsule casting techniques for precise interaction and collision detection, replacing traditional methods in certain situations for better flexibility and performance.

#### *12. Unity Layers, LayerMask:*
Organized game objects and interactions using Unity Layers and LayerMask, enhancing performance and managing complex scenes more effectively.

#### *13. Unity Prefabs and Enums:*
Efficiently created and managed game objects using Prefabs and Enums.

#### *14. Delegates, Actions, C# Events, EventHandlers:*
Managed in-game events effectively using Delegates and Events, making the code more modular.

#### *15. Singleton Design Pattern and Statics:*
Utilized Singleton and Static structures to share data and provide access through a single instance.

#### *16. Scriptable Object:*
Used Scriptable Objects to organize game data more flexibly, enhancing sustainability.

#### *17. Inheritance and Interfaces:*
Organized code by facilitating code sharing between classes and defining common behaviors for different objects, promoting code modularity.

#### *18. Generics and Structs:*
Utilized Generics for creating flexible data structures and learned the performance-oriented usage of Structs, improving code efficiency.

#### *19. Canvas, UI (Menu UI, Fail/Success UI, Progress Bar UI, etc.):*
Enhanced user interface design using Canvas, making it more attractive and user-friendly.

#### *20. State Machine Design Pattern:*
Implemented a state machine to manage the player character's different states, enhancing modularity and control.

#### *21. Shader Graph:*
Used Shader Graph to create custom visual effects, improving the game's aesthetic appeal.

#### *22. Audio Source, Audio Clips:*
Managed audio sources and clips using Unity's audio system, enriching the in-game atmosphere.

#### *23. Scene Loading:*
Learned to manage scene transitions effectively, loading and handling different sections of the game.

#### *24. Game Pause:*
Implemented a game pause mechanism, providing users with better control.

#### *25. Player Prefs (Data Saving):*
Used PlayerPrefs to store game data, ensuring a continuous gaming experience for users.
 
</details>

  
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GAME SCENES -->
## Game Scenes

### 1. Main Menu Scene

![MainMenuScene](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/9464f140-6d99-452b-a971-81f28707baa3)

### 2. Loading Scene

![LoadingScene](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/e8bde6f3-e5a1-4246-94b6-3acc493b9087)


### 3. Game Scene

* #### *Game Scene Tutorial UI*
  
![GameScene_Tutorial](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/959cbb8b-835a-49c4-b07c-c1d4c2432540)



* #### *Game Scene Countdown UI*

![GameScene_Countdown](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/bb0927b2-2385-45fd-8cd9-e9414bafea71)



* #### *Game Scene Playing State*
  
![GameScene_Playing](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/acd9e85b-a16f-4167-b8a1-64222b757e43)


* #### *Game Scene Success UI*
  
![GameScene_Success](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/78ecd9eb-3d1a-42d2-815a-47753fa651d4)



* #### *Game Scene Fail UI*
  
![GameScene_Fail](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/08f21ce9-2050-4122-bf46-faa63fe07975)



* #### *Game Scene Pause UI*
  
![GameScene_Pause](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/9c25f6ea-9eb5-4554-8e94-a0fd2429069a)



* #### *Game Scene Options UI*
  
![GameScene_Options](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/9ef6d649-5cf7-441a-812b-a36d2c204b23)



* #### *Game Scene Key Rebinding UI*
  
![GameScene_KeyRebinding](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/b7b358df-0dc2-47b1-a835-a157fa79701c)



* #### *Game Scene Game Over UI*
  
![GameScene_GameOver](https://github.com/ezgiksrci/Kitchen-Chaos-3D/assets/16293095/408b6a02-e162-415a-baf1-6ceb0b6fab1c)


<p align="right">(<a href="#readme-top">back to top</a>)</p>  


<!-- TOOLS AND TECHNOLOGIES -->
## Tools and Technologies
:pushpin: Git, GitHub

:pushpin: Visual Studio 2022

:pushpin: Unity 2022.2.13f1

:pushpin: Universal Render Pipeline

:pushpin: Unity Cinemachine

:pushpin: Unity Shader Graph

:pushpin: Unity (New) Input System

:pushpin: Unity UI

:pushpin: Unity TextMeshPro

:pushpin: [Background Recompiler](https://assetstore.unity.com/packages/tools/utilities/background-recompiler-234979)

  
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- RELEASES -->
## Releases

- **Windows x64**
	- https://github.com/ezgiksrci/Kitchen-Chaos-3D/releases/download/Unity/KitchenChaos_x64_exe.zip
<br>

- **webGL**
	- Soon...
  
<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Roadmap

- [ ] Restart Button
      
- [ ] Selectable Player Color
      
- [ ] Android Build Features
	- [ ] Touchscreen Support
	- [ ] Landscape Rotation
	- [ ] Optimize for mobile 	
       
- [ ] Multiplayer Support

  

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Acknowledgements

I would like to express my sincere gratitude to [Code Monkey (Hugo)](https://www.youtube.com/@CodeMonkeyUnity) for sharing his knowledge with us through this educational video series and for his mentorship during the challenges we encountered. I am truly thankful to Hugo for his guidance. His instructional approach and passion for game development played a crucial role in the realization of this project. The educational materials he provided not only contributed to my growth as a game developer but also enriched my journey as a learner.

The dedication shown and the value of the shared information have turned this project into more than just a technical achievement—it has become a learning journey and a community experience. Hugo's commitment and the significance of the shared knowledge have made this project a profound learning experience.

If you are a video game development learner then you should check [Hugo's YouTube Page](https://www.youtube.com/@CodeMonkeyUnity).

<p align="right">(<a href="#readme-top">back to top</a>)</p>
