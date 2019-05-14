# Yulgang Change Title
โปรแกรมนี้จัดทำขึ้นมาให้ใช้ฟรี เพื่อช่วยเหลือผู้เล่นที่เปิดหลายจอ เปิดตี้หาของหาเงินหลายๆ จอ หรือสำหรับพ่อค้าที่ต้องการเปิดร้านขายของหลายๆ จอ แล้วเกิดความสับสน บางจอหลุดต้องมัวเสียเวลาหาว่าจอไหนหลุด จอได้เด้ง หรือจอไหนหายไปเฉย ๆ

![](https://i.imgur.com/mbPWe9N.png)
## เริ่มต้นใช้งาน

โปรแกรมนี้เขียนด้วยโปรแกรม Visual Studio 2017 และใช้ .NET Framework เวอร์ชั่น 4.6.1 เป็นอย่างต่ำ
### ดาวน์โหลด
[ChangeTitleYulgang Version 1.0.0.0](https://github.com/meawmuay/yulgang-change-titile/releases/download/v1.0.0.0/ChangeTitleYulgang-v1.0.0.0.zip "ChangeTitleYulgang Latest Version")

### ติดตั้ง
ตัวโปรแกรมไม่มีความจำเป็นต้องติด แต่หากคุณยังไม่ได้ลง .NET Framework เวอร์ชั่น 4.6.1 หรือมากกว่า ดาวน์โหลดได้จากลิงค์ด้านล่าง

[Microsoft .NET Framework 4.6.1 (Web Installer)](https://www.microsoft.com/en-us/download/details.aspx?id=49981 "Microsoft .NET Framework 4.6.1 (Web Installer)")

รองรับระบบปฏิบัติการ
- Windows 7 SP1
- Windows 8
- Windows 8.1
- Windows 10
- Windows Server 2008 R2 SP1
- Windows Server 2012
- Windows Server 2012 R2

### หมายเหตุ
ไฟล์ credit.vd คือไฟล์วีดีโอของหน้าเครดิต ทดลองเปลี่ยนชื่อเป็น credit.avi แล้วเปิดด้วยโปรแกรมเล่นวีดีโอตัวไหนก็ได้ สามารถลบทิ้งได้โดยไม่มีปัญหาใด ๆ

ทำไมถึงขึ้นตามรายการด้านล่างนี้
- Publisher : Unknown ในขณะที่เปิดโปรแกรม [(ตัวอย่าง)](https://i.imgur.com/peSlQDG.png "(ตัวอย่าง)")
- ตอนดาวน์โหลดเสร็จ บราวเซอร์แจ้งว่า "ไฟล์นี้ไม่ได้มีการดาวน์โหลดเป็นที่แพร่หลายและอาจเป็นอันตราย" หรือ "This file is not commonly downloaded and may be dangerous." [(ตัวอย่าง)](https://i.imgur.com/FkxEtZs.png "(ตัวอย่าง)")

เนื่องมาจาก ตัวโปรแกรมไม่ได้ Publish ด้วย Code Signing Certificate และตัวโปรแกรมต้องการสิทธิ์ Administrator เพื่อเข้าถึงฟังก์ชั่นตามด้านล่างนี้จาก Library user32.dll
- FindWindow
- SetWindowTextA
- GetForegroundWindow
- GetWindowText

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details