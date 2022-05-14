需要自行下載的資源，並麻煩放進Assets/Resources中(如果只是要擺放360環景圖中的角色就不用)
1. Erbeilo 3D - Built_in RP Chiness Moduler House
2. Oriental Structure Pack - Lite
3. 360環景圖請自行下載，放進Assets/Resources/Panoramic中

如果有新增角色也請放進Assets/Resources/Characters中


4. 根據以下連結在VS安裝interop.SpeechLib.dll

https://dotblogs.com.tw/DavidTalk/2018/12/12/140614

5. 根據以下連結去下載Zhiwei繁體男聲

https://support.microsoft.com/zh-tw/windows/%E9%99%84%E9%8C%84-a-%E6%94%AF%E6%8F%B4%E7%9A%84%E8%AA%9E%E8%A8%80%E5%92%8C%E8%AA%9E%E9%9F%B3-4486e345-7730-53da-fcfe-55cc64300f01

6. win + R 輸入regedit 再根據以下連結去新增Zhiwei繁體男聲，即可得繁體文字轉語音機器人聲
https://blog.csdn.net/u014137602/article/details/89707076?spm=1001.2101.3001.6650.1&utm_medium=distribute.pc_relevant.none-task-blog-2%7Edefault%7ECTRLIST%7Edefault-1.pc_relevant_default&depth_1-utm_source=distribute.pc_relevant.none-task-blog-2%7Edefault%7ECTRLIST%7Edefault-1.pc_relevant_default&utm_relevant_index=2

7. 此男聲在每台電腦item可能不同，要自行在regedit察看是幾號，並進入text_to_voice.cs中將原先的ChatbotVoice.GetVoices().Item(5)中的數字改成自己的

若4~7點沒成功 會報以下錯誤

![messageImage_1652533296836](https://user-images.githubusercontent.com/59390771/168429217-35d8cee0-fb63-49d5-a5fa-6530705df67c.jpeg)
