![alt text](https://github.com/hariomenkel/RedlineNetSpam/blob/main/logo.png?raw=true)

(Logo created by https://huggingface.co/spaces/dalle-mini/dalle-mini)
# RedlineNetSpam

Since I realised, that my other repository for Redline Spamming (https://github.com/hariomenkel/RedlineSpam) only works with older, less popular version of Redline Infostealer I thought it might be worth to have a look at newer versions relying on NetTCPBinding for communication instead of SOAP.

Since there are already a lot of good documents out there explaining the inner workings of Redline (My favourite: https://medium.com/s2wblog/deep-analysis-of-redline-stealer-leaked-credential-with-wcf-7b31901da904), I wanted to pursue a different goal with my project.

Cyber crime - in my opinion - is a business like any other. Criminals want to be as profitable as possible while trying to keep their work load low and their reputation high. We won't be able to stop cyber crime, let's accept this cruel truth. But what if ...

- we would be able to undermine the trust in the product (Stolen credentials) of specific actors
- Map specific malware campaigns to specific sellers on darknet forums like Russian Market
- Make it less profitable for criminals since they have to find the needle in the haystack when searching for data
- Sprinkle stolen files with canary files which might give us more information about criminals, ideally leading to their arrest?

To pursue this idea, I created RedlineNetSpam which is able to
- Extract the configuration from Command & Control servers (Steal Browsers? Make a Screenshot? Steal files? Which files)
- Create fake Credit Card Numbers which pass validity checks on Russian Market
- Create fake Credentials
- Create fake Cookies
- Create fake OpenVPN configs
and much more!

To achieve this, I grabbed a Redline client from Any.Run, decompiled it and removed all malicious actions while replacing them with generators for fake data.

# How To
You might probably want to run this application in an analysis (Windows) VM. Since you probably do not want to see your public IP address getting leaked it is a good idea to tunnel all traffic of the VM through Tor network. I came up with a quick tutorial on how to achieve this:

https://mariohenkel.medium.com/setting-up-whonix-gateway-in-vmware-workstation-f943cd9a529

After setting up your environment, head over to https://tria.ge/s?q=family%3Aredline and be on the lookout for samples showing "auth_value", since you'll need them later:

![alt text](https://github.com/hariomenkel/RedlineNetSpam/blob/main/hatching.jpg?raw=true)

Once you got a config and consulted your lawyer if this is allowed in your country, start RedlineNetSpam:

![alt text](https://github.com/hariomenkel/RedlineNetSpam/blob/main/running.jpg?raw=true)
