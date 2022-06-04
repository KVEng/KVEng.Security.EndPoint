<div align="center">
  <h1>KVEng Security EndPoint</h1>
  <img src="img/banner.png" alt="KSE">
</div>

## Claim

This project is currently under early stage development. Some features have been implemented, but we (KVEng organisation and  KevinZonda) have no guarantees that these *must* work.

Use at your own risk and follow the laws. We do not guarantee the use, safety of this software (KSE, KVEng Security EndPoint). We also will not be liable for any adverse consequences from using this software including but not limited to violation of local laws and miss-using the software.

## Introduction

KSE, abbreviation for *KVEng Security EndPoint*, is one of the most easiest solution to provide MFA verification for personal Windows users. To be claimed, KSE does not contain any disk encryption, if you want such solution, maybe you can try BitLocker or VeraCrypt, we do not shoulder any responsibility for this advice.

## Features

* Hard to kill, KSE makes itself as a Critical Process to prevent malicious closing, e.g. Task Manager kill. If do, a blue screen which represents fatal error of Windows will be shown.

* Support OTP, which requires your 2FA to ensure your device is trustable.

* Protect automatically, once you lock or make your device sleep, suspend, KSE will automatically detect and start protection.

* Light weighted, thanks to .NET 6, we do not need to static link all libraries.

* Open sourced, we open sourced our whole code to accept the whole world's reviewing.

## Future Plans

* Support FIDO2 hardware key
* Support Windows Services interface
* Connect KSC (KVEng Security Control) to support online manager
* Support NTP auto adjustment
* Recovery key

## Screenshot

![](img\locker.png)

---

KSE is a product under KVEng organisation. KVEng is short form of KevinZonda Engineering. Copyright &copy; 2022 KevinZonda Engineering. All rights reserved.
