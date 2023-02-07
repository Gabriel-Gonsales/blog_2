<template>
    <div id="App">
        <div id="banner" class="">
            <h1 id="titulo_banner">Este é o meu blog</h1>
        </div>
        <div class="mh-20">
            <img id="post-img" class="col-md-12 img-thumbnail" src="data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBUWFRgSFRUYGBgYGBgZGBgYGBgYGBgZGBgZGRgYGBgcIS4lHB4tIRgYJjgnKy8xNTU1GiQ7QDs0Py40NTEBDAwMEA8QHhISHzorJSQ0NDQ0NjQ9NjQ0NDY2NDQ2NDc0NDQ0NDQ0NDY0NDQ0NDQ0NDU0ND00NDQ0NDQ0NjQ2Mf/AABEIAIwBaAMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAADBAECBQAGB//EAEAQAAIBAgMEBwYEBQMEAwEAAAECAAMRBBIhMUFRYQVSkZKh0dITIjJxgaJTk7HwFELB0+EGYnIVM4LiI0PyFv/EABoBAQEBAQEBAQAAAAAAAAAAAAIDAQQABQb/xAAqEQACAgEEAgEEAgIDAAAAAAAAAQIRAxIhMVETQSIEYXHwkaGB8TKxwf/aAAwDAQACEQMRAD8A+OZzxPbOFQ8T2mVtOtErML+0PE9sn2h4ntMoFk5ZVSZ4utQ8T2wyVDxPbAKsKgnXgm1yCVBkqG4uTC5yd5glW8doYfmJ9HHJyITkluCNM22mXw9Qg6/rHBhzxEr/AAeu2dKi1uiPki1TCNUzETv4a8vRw/OaNLDm20S8Y6uTmnkUeBClRym80Ue/CScPzE5aXPZLRSic85qW7JKiQp12Qop8xKlIrROy6GdVcQV+cq3znrRijucCNs5l3yoWcz2mWh10UaAZt0IzXgjJyKxRJEEwhRKMIWikQTfKU+n6y7LK5f3p5TnnEqi6Ly/WPYemOr4GJ0l5DsHlNLDJqNB2D0yOknNhXwxX5HZ5QiUbzWw1IMMpGhlHwpQ2Ow7DxmOV7Em2tzJr4TSYuMw1p9KwOAo+yNatmIzZFVbAkgAkkkGw1EyP9Sf6esUegrOjrmF7Bl1IKn6iccpRbovBSSs+cvSnJhyZ6L/oFcn/ALbdq+cOvQFb8M9q+cKxp+yzyNLg86uFEuMKJ6Regq34Z+3zk/8AQ634Z7V85aOOPaA8kumeZbDEShpz1DdCVvwz2r5xKr0FX3U27V849MV7Qozb9GAVtDK9xzH7vsM0X6CxH4Tdq+cC/QOJ/CbtXzkp0vZVJv0Z7A8D93pgWU8D93pmg3QGJ/CbtXzkf/z+J/CbtXznPJplEqM4oeB8fTKmkeB7D6Zqr/p/E/hN2r5wtP8A05iDtpN2r5wNWK6MNqR4Hx9M6blb/Tde2lJu1fOdBpNs8xadaaVPoqo2gUjUjXSxC5teGm/nDDoCtpoovl/mH83lv/rJrBN8RYnmguWjJVYdEEefoWsupXQAk21sFNv8gbxBnCspIYWINiDuPCb45x5RmuL4ZFOivARmnh16okU0jdK3CVhFglILRwydUR6lRTqiCouOBjCVV4GfRxuSOPJuM0KaHaohXwycBApiF4GMriV4GdcZM4ppp7CppJfQCFUqNwl2ZeBhsLhg1ydFFr8TytffqNJRTonKSq2J3udBfbsF9gv+gPZBVKLi5ytYX1twUMb/AEInoSmVSyjKqi+lsxyg2u3GB6LrNWzLdgVANwSRY6ag31nvK6sksuzaWyPPvVIOU3G4gixB33vLZt02cRUpOSjEMR/MuhGtzfS2p2kTJxWHKNlP0O4jiOUpCd8lYyUtqpi+cDbKPUlaggXMbZaMUw6vznE3gUa8524T1m6dyGa0oHEhk3mBF7wOVFVFMYZp0BnhUNzaZqRumirSMsb9kpuBe47DaAVIWkxcFqSR+gkBRSPUVk3sQnI2Ojat/dO39ZuCmrrlb6HeDxnmqQm5gcTcWO0fu85Mq9oyEvTCYXEVaQamaQqITexViL9YEbDaZfTRrV2DNTICgKqhCFVRsAE2Ha5//P8AUGCe3L7PTJxrVqrc2UnWm9jzVPot9fcbumFXo5uoe6Zvoo5fZ6ZzUxy+z0yyyEWYf8Aeqe7KNgj1D3ZttTHL7PTBOg5fZ6YlMyzCfCHqHumZ+KwjdQ90z0j0xy+z0zPxNMbNPs9Md2OE6POPhG6h7pgHwbdQ90zfaiOX2emDNAcvs9MnKFnRHK0YP8E3UPdMuuBbqHumbX8OOX2emXWgOX2emHxFPMzJTAN1D3TDpg2H8h7pmmtMcvs9MsUHL7PTFoQfIzFxGGYi2Q90+U6adVBy+z0TpN41Y1k2EjijqTbZ4QK9NkG4QfPQeEHQTNcHfpMPEKysVO0G3kYM+acEmuGLFijJtM9TT6ZRvjQg8Vt+kbNam4NrMDeyn4gWFiQDre2+eJDnjD4UVHZVS5Yn3bbb8b7vnIR+qb2ascvpkt06PTVOic2ZqV/dGYqb/CF3bSSSPGIZGUlWFiNoO0T0TqVIIYXsA28E21NvneL43CiqunuuNl9B7zDMWyi7Gw0nTLD7ic8M74lwZaPCpUmSc4NjcHgbg9hl1duMzHMvKNmoa8smKmcisdBc/K/G0cTo+t1W3eLFf1BE7IyISjFcsfGKG6egFAlfZjQ5Sdbj3iN4N7G1u0zxoVgRccDqN3yO2b/S9ercCkGA0Pu7dUWw90nTRtmkUt6OPNjuUVFmp0dh2pKxewzEBVGuovttGcHXRSyKFHWClbjd7wU3H9IjUxTZVDXzBVZyF2W0uDszDbaY/QmAdaoYsuUXuQwJa4tbLtA11zWgau2zm8epScnX/pp08FRplqpqgqCyqCLWO8E/zEcoj0mVanmBHukWNxYqdmtrtvAF5p9OYEV1ChwpVmIuLix2gj6DWZVZRSwzKDcgKt7kXJLE/DfTXYdDxii/ZTFUtMrt3VfYxwTI9kYFavGeg6E6L9ovtHuqA2GhBY62ykjK1ipBBlXNRVs7JvQrZjLRIEt7HfPfphqYFlRANdMpYi7ZrE346jhEsb0fTf3coU7mXjmZstibAkm12v8ASTWf7HLH6uMnTPE1FME1O2yPYlCjFGtdSQbG4uNtjviTtG2dsNxZlMNSuNZIMusK5KNh1q8hfeZ2TsMooh6R3HZ+9RNslKQSkI7SiyBeJ7o9UZp5eJ7o9UnJkmhymY3Ta2oidMr1m7o9UaQp1m7g9UhILQ7/ABQ5+PqE44kcT2H1xUFOs/cX1yCU6z9xfXAkgSbGv4ocT4+uEGKB3nx9czyafWf8tf7kqWp9d/y1/uRKKDv+0PNiRxPj64F8SOJ7D64s1Wn13/KX+5F3q0+vU/KX+7GkjVFv9QxVxajefH1xJ8QDvPYfXKMaP4lT8pP7soRR/EqflJ/dlE0v9FFB/tHGsOJ7D65U1hxPYfXIIo/iVPyU/uyLUfxKn5Kf3Ztr9Q1BlvbDiew+uR7ccT2H1ylqP4lT8lf7s4ij+JU/JT+7PWv1C0sv/Ejiew+uQcUOJ7D64Mih+JV/JT+7KMKH4lX8lP70LaEoMl8SOJ7D65MCwofiVfyU/vSYbQtBn4dwPe231ifS6BiHHyb57oXDKcgH75RqnRXmb9nZOSS1xp+yyeidmFSoZiFFyToANpM9X0Zg1oKdhdh7zbco6qnhxO+VoUAuqqtztIUA/KR7S+uwDbFhwRh8nyHLmeRaVwOriAoNR9g2Didwi+E6RztlcKM3wkbjuB5HZMXHYou2nwrsH9fnAq9p55/ltwj0cC078v8Ao3OkMKGJa1iCc1t/Mn6WgcHgM7WvYDVjpoBqddl7XOvCMUavtFB3kEMTszKNpG/cZFCqUos+W5HvG4tfUBQwBNxc33bDLVG9XrkClJR0++DRq1fYoopqFvf3iBnbRcxub5VOVTlEYV19iaxaoTstnO29tvCZ/RuMOIRg6qcpFrAi5bhz08RL4rpBF/8AiuotZSlmIN91/rtlouNWnszmlGTlprdPf8FqOJZ0YMAwW172zC4IurbyBfbeNUsR7qspvluBxK32bB8NwLfOZWKxBpJemuVr2awuV02/XTtg6BqZCx0LAspsRqttbAc9w3RWk6NeJSV8K9hzo3FVqlazElDe9x7oA2WmoOk1WoKQU2zBS2nxHQD5X/rPO4PpSxsysGO0rv1AvbXdck8o5UxtMMGZmB2/Dre5BPC4A4b4U41yHLhuW62rai3SeBY4j2isCMwI11FrXW3b2xDpnFFrUkN7atlvqbXsLHUDmNMs7G9Jtl9xctwLljdrMOPz2Wmr0RhlpJ7VwCx94lr2FrnMRc6i7C42gzHK3SKK4RUpbtbJHmWouBdlI3ag9UN+hB+RnvMCAtGkoFvcLH3VU3ZrZjlJBNlG++kyj0slW49x1FgwClGANhex2roAbcrwlPHKtqJNrXy6AXBuToFUW37/AIts1fKt9if1GvJGmqa3ND/UHTLUCiU0BGupvY20sLb+Zv8AKExGK3FbZlBI4XA8R/SAfFFhoVNthPLnEq1a412k2JGgHIHeZsYJHKoJpLTuuX2Zn+oKgZ1YNqyqTcsTsHEWA5DnMhvmJsVuj2qNmdgi5WKhiQbLsIBJ02XtaI4rollUOrKwyqbg6ksbWVdttmphlNpcH1MWlRSsUHzEKpgUQ8IQIZNZCjQdWhEbnBIhh0Q/u8op2RkgqNzhUc8ZRaZ/d4VaR5eMTZNoKjnjDrUPGBSieXjDph25ePlJSoLiT7U8ZRqrdaMLhH5ePlLDo9+X3eU8pRRNxAoDa5YQOIJGxpp08E9rED7vKUq9Gu25fv8AKNTiBKWrgxnqN1hAu54zZboepwX7/KCfoepwX7/TKKceysfwYzOeMoXPGazdDVOC9j+mUboepwXsf0zdUeyq/BlFzxkFzxmmehqnBex/TIPQ1TgvY/pnrj2JGYXPGVLnjNP/AKPU4L2P6ZB6GqcF7H9M249jSMoueMqznjNU9DVOC9j+mVPQ1TgvY/pgddiSMhnPGdNNuhqnAdj+mdJ19xieFGuWMVKgWwOm6JYZ2vpB4pWLX7L7px3UbMUblTN3BG8p0nQ0OXTMCPrt8YPoskLrGMdU0H/L+hllvHchTU9jzRpHjINE8Z6JHUn3kVvmB+sivgqR0Csp/wBp0+68g8D9M6Vnp00JdDXAYHcVbtBB/QTWw9ZVQs2oym4GW5IN7EDec2/6wWDoIinLck6sTbYAbAW+cVp4gXNNth1FzcA8P9osTeWgnGKTIy+cm1waPR2OV1IVMhUg5Vtax3i1tZh4nol85sbqWFmLKTY/zHX59k0GrrSRii2Jte9yd+/hL4PEs6M5W7LfUDbpeU+Mkoy5XQVqg3KK2fYWq5poXsWPuqpOhaw+Jvnr4StHGNWF2UKQGB1NhoBe+mnvcYLBY4uGR7MLaab77Lb5SpX9mwXQG4uBplG0C9jxvcfKUlLa09gKHKa37NR2p4dRdQzEa3023GvxakaaaHLeXovRxIYFQrAEqL6HUEi9gRra8Wx1M1VBXXYdNuzeNtrW59sZ6GwXs7vU90AG19NSANm4AX28ZNN3Xoxpabv5Hn8UxDlCpFja9rXHNd3GbC1A9H2ewhSpGgOvIAAHS9uG3bFcVVRmYqtiWAOwb9SLG246zMq1DmJXibWtbXbs0+sV6ed7KadaXpo1Oi+j8mYk3zCxNrWW+Y2FzqbQfSuFao4ZfdWzC+zYAbfFYg6WI467IzgcNUcZmuN9tg+LMCuvO0dCqPdAuRoTpbja52n5RqEXFLhEnklGbd2zKC1lW91Iygk2vqzD3RbafCxjGB9o5YtrkuMrDKhIbRST/MCdBt0AjrupAtccCpB8Rt+UToV1VyGUWObNmJyqT7wYrv1CniNZjTTu9hKSkntuB6RxhQ+zVdduZjmuDqbX3Xv2TsJWb/uAZQWCsFsxYDh9TL9JYUM2YswYkLexysSARl46QaMqqLZwgPxZrOXXdrrrJty1O+BpR0qufYvjqORytiBuucxPM8Dyh8DhQ13bYN2m3+hkVEzsaj+7717KN1jt53h8G4UMuYkG3IjZuPOCMXdtClJaaTGnZCuXKOGg3jXX66xApYw/tADcnnpv3iLmvfjsHaNso9gJhlEIhgfaXtqZZWPGNcGNocQxqmeZmcjHiYdHPE9sEkFyRrUzzMZS3E+EyUqN1j2mMpVbrHtMk4slLIkaqAcT4QwUcW8JmJVbrN2mHWo3WbtMm0TeZDhQcW8JRkHFvCAzt1m7xg3d+u3eMSTM84ZkHFvCDKDi3hF3d+u3ePnAs79du83nKKL7EvqBwoOs3hKlR1m8ImXfrv3m85Q1H6795vONRfY19QOlR1m8JxUdZvCZzVX6795vODas/XfvN5xKD7EvqDSIHWbwlSB1m8ItQoVHGb2jAbvebXximKNRDYu/I52sfGao26sqsrq6NBrdZvCdMR8U/Xfvt5yI/CxeYwcFU7YdteEQdcoud+wcZaliCSBci+/bPlKdbHU4X8kbeHYKLnT9BA4nFAsDu3D+pgzRI0YnSK48FX2aEAj9JWUnGJOEYuQ6uPA/lEuMcp29syAzS6KxNhvhjlkUliiemwlIGyqA7OMyqxOXLexJttPAfrsmlXwTkW9ywbUFKbDJwKAfFs4Rfot9cozAlFCFj7oYIBZNdNmvOJdCYfEJXu+YLrmLHQ/KVcuzlUW7afAh0iy2zZSLfGh3AnRlNybHXS+kWw3SgUZVDfIW4XNtOMa6UrLmc2FirAkMDmYkAXA2WiNJVC5hs2iwJIN7MLHdsF4XJqXxZVJOPyRepi2AJVLaBsx22JFj232bYGrqDbbvB2g8OybFIHgws63sQ1yw0CqDcjTcOEvWwQsSdt2JOijN8IVt972HzFo95ewqSXozcBUqIuYbtQvHeRpxtb5Q2Gx71LhzpbnqdQQOZBPYJnVqxVipytY2JGlzrfxI7JQYtti2Hy27t/zHjCsqVb8DeNu3S39jdZlW9r5rbN4HE22bYkxcbQdCAfmRcR3B0s3z112EXIOscNAMCFZWK6lQQSLcLRv5b3RmpR25NHA1rUlC5djfCSVvc7CdZk9KuxWndRlAIuNpY2zA89ITB4qwKMdRqPhCqNBa+mpjntBex01B1AtcbDY7DKSeqNWQS0ScqAdDs/s21GUMMo3htCSOAtKY+r8Y12C+U2J2+G2Hq4tRvzH6D66adszMdUFitgST71wQQeXLdMctMNKYoR1T1UVpY+oB8ROuY3O3S3ZOwzl3BYknmfCJLWtoRC0q9jcDxtIRlurZ0ShV0jXrVSLZdNNfn+7dsqxN1Owka2+sCMapF9hlHxAudpPGW1b3ZHTtVFhCLAo44Ht/xDoRwPb/AInkzGgqwolUI4Ht/wAQyleqe9/iWTIyOWGQyqleqe9/6wqMnUbv/wDrCycmuwiGMIYNHTqN3x6YdHTqN3x6IH+CEq7DI0YRoFaidRu+PRDpVTqN3x6IHfRJ12XvIMuKydRu+PRGujcVSWohZSAN5YEA2IBIyi9jY/SBtpN0eioykla3EsRhnUAsjKDsJDKD8riLMJuMWSnVFWqr51AVQ+cs1wRUGpygAbTa8X6Lwlz7RtgPu82467h+uuxWno5fi2/X9lHi+Sivffo7C9Gpl99bsdSLkZeWhGuhv8j1TGD0TS/D+9vVDuf3qP8AI2fMZeK69Tfdcjhw/wAfvcVuHOT3s6owitqFT0RS/D+9vVKN0PS/D+9vVH//AC8RIP8Ay8RNU5dstGEekRQwNLKBktYW+M+qJ4/o2k5A9ne2/O2//wAo0w/3eIg2H+7xE9FyTu/+y6jFqqMp+hKP4X3t650ff/n4idH5J9v+RaIdHyRqZc3J/fCWXCwbUnT4lZfmCB9DOFUzhun8kdCe2xvUhmRT/MPdP02HsgMbhSyBt6nwP+bSf9PM7M62uuW5tuIIt9ds3Fw9gQwGuhHLgZ3wSnCzhnNY5nkhRM18L0aUUu2jEd0TVpYalTu9tQL3JvlH9Jg9K9JFmIU6cd2lrEWOsLise7H5JZXUdl7Oo4oKSCdmbI4GbLm23W+o/TnGcRjmYWNVbWX3gXzXFszZcu/XSYntDILmReQt4kwtSzMbD3b5tyknjYbBt05zX6OwIcliwyouZmAykrqQP115RbBJmQlLF1sbBGuBew97eSbbOE2MDUUFkfOEqBgHdQrNtViwF9L3+XbGltaJzfrop0bUoO/s1zoxPuPfeNmn0vxl3AVsr5FOYgrkJLsfeznlYD6EWhei+iKdGoK1SsGVNUCjVjrbUEi/L5HSCxmIZnZ/fAdi1lAyMFJ929xqDl/xHFv2Rkl6ZgdM072e5bdmsFXS+gXaDpeZSrrNXpuoLqAQx11LXccVdRoNvhMnOZzZZfI68S+KPQdF2YFC1rqVzW0Unnv2HX5S2B6Hai3tajLlUEDKbliRYDxmFRxbJra/C+wc7Q9XpIkWC23a7xz5xeSLpt7oDxyTaXDJx9UFrcN1rW+u+TT6QYEX94XJIO/TZyHyiBJOpuZIgeWTdlFBVTHK2KYqB/tseB1ve24wCVDvlQZOWa5tuzVFJUWeSjSmUyQDPanZ6gl4dLRZVjCCKMmGUUNU0EdpUhzidGaWHEtGRGURilhV5xpMEnE9s7DjlHaa8pXUyTigKdHpxPbGE6NTie0RimnLxjdNOXjJym+w6I9CqdFU+LdojCdE0uLdo8o6icvGHReXjJPJLsx44dCS9E0uLdo8oQdFUus3aPKPAcvGT9PGZrl2DxQ6QovRVHrN3h5Qy9D0Os3eXyly/Lxne25eMy59mrDDpFT0Nh+s3eXyk1CqjKtrAWFtwH7/AK6+9erYjl4wFSpfd4zVFvlnnGK4VHM/71H+d30y8V1Qx+KIGRfiPD+UbL6bOA+u7La2JxARSTu3bLncPD6W5AnMwWMArLUbUBlZhxAINuwWnRCDq64ISlT09j7dDYlVztnVLXZrm4X/AI3vfhfeZm1Olal/dbKu5bKbAbLsRcnnvnqmr01epX/iFqCoGC01uXYvcBWW2liR2TyNbEZDkQjT4mABzNvsSPhGwcdTvm4ZOf8AyX9UPJFQrS3/ADZVulq3X+1PKL1OmK/4n2p6YRse/W+1fKAqdIVOt9qeU64wXSPRk+2LVemsR+J9iemTKVekanW+1PKRK+JdIupOuWEwXTK2s3gePIyz4+m3/wBaHmyod9r7J5BKkIKk+SvqbW6Oh/Txu0euTpILopCjXQZQNNoAAidfH3N8xP104j6Tz4qSfaTz+pb4NWCKdmjiKxf+aw4D5WMW9iOMXzGSCZGUtTtlkklSCGkOMg0hxlLNwk5W4Q19hWN4DENTYMpaw1yhioJsQCbbbXmkuV8xQgOwSndruSxIZmUt8J07LzCCvwkqXBuNCNhFwR8jKRk4qq2JygpO1yeoqYdQSVZUUsArZgcmQe/mv8SsbHNbfaZuIrooJyi5OYqNMrMSSybiNmm6ZOepYC+gBA27DqRKMH4DxilldbIEcPbIrMzHMxJPH5aCBywhD8vGVs3LxnM02X4KFZGWWIblOyNymUesgCQZb2bcpHs24iaYVEsGkexbiJxpNxEzc0tmMm5g/ZtOCtEmYwqkw9BGbYfGKgNG8G9rg798aewWhv2bLY305GGp1G6x7TKtWAUKpvvJIH9ZFOqf9vdXyl8dshk2HUxD9du8YdMS/XfvN5xNMQf9vcT0w64w8E7iemdcYnLI0aVd+u/ebzjtKq/XfvN5zLo408E7lP0zQoYw8E7iemGcGSY6ldx/O/ebzhBiH6795vOUTEkjYncT0zhijwTuJ6ZLS+icvyy7Yp+u/fbzgKmLqfiP3285dsUeCdxPTANXYmwC/l0/TKRj9ibf3YCpj6n4j99vOLv0jV/Efvt5xiviLaWTuUvTEqmL5J+XR9Mskul+/wCBQ/LJ/wCpVPxKnfbzkjpF+u/fbzi5xvJPy6PpnDG8k/Lo+mJV0v3/AAV0rtjD4pm+JibbLkn9ZQ1ZQY3kn5dH0yf43kn5dH0xpfb9/gGhfcZFXIub+Zh7v+1ToX+Z1A5XO8GImrK1qwYlmNyea/oNAOUESv7I844xS5HpQVqsE9SUJXj4jzlCV/bDzlYpDUSrtJkNl/ZHnOjopsYCOOEKGHCZ6MYVXM/KRmfVaHRbhJ04RRXMurmPUZQ1blOHyi6uZbOZtnqGlPKEB5RMMZGcxKRlDwblJz8pn5zJMXl+xlD5qSC4mcZEPl+xlDzMJSKiWAmOaZtDBWcElAohFQTy3PHeznCkZdRDogiUbCAFAzjhzH1QSzII/Gj1mWcKZH8IeM0sglLQuFGiH8IeMkYY8Y2wlWnkYwS0+cIBInGXgyEkERtJBqwW6BYxPI0FQTH6eIj1DFTBVjGKTmKGVvkMsaPTUcXDNiNZhUXMYzm86UkzklCjXWpfQQ9wot2xPB7L75eo51/fGa1uQaAYipt2+PqiFWp8+1vVBV6h4xCq5mtUdGPGONV+f3eqV9r8/u9UzWcymcwJ7nSsZrit8+1vVO9t8+1vVMkOZ2cy0WZ4jVNb59reqDNb59reqZmcypcxWJYjT9t8+1vVO9r8+1vVMvOZ2cxxYvEaftPn2t6p0zM5nSlnvGf/2Q==" />
        </div>
        <p>{{ message }}</p>
        <!-- v-model é uma via de mão dupla com o data-->
        <!-- .lazy permite que seja impresso só depois do "enter" ou qualquer evento de mudança, sem precisar mudar após cada input-->
        <input placeholder="Escreve aí" v-model.lazy="message" type="text" />
        <!--v:on permite vincular a eventos, nesse caso, do tipo click-->
        <button v-on:click="reverseMessage">Inverter Mensagem</button>
    </div>
</template>

<script>

    export default {
        name: 'InverterMsg',
        props: {
            msg: String
        },
        data() {
            return {
                message: ""
            }
        },
        methods: {
            reverseMessage: function () {
                //split separa caracter
                //reverse inverte
                //join retorna
                this.message = this.message.split('').reverse().join('')
            }
        },

        //watch observa cada atualização
        watch() { 
        }
    }

</script>


<style scoped>
    h3 {
      margin: 40px 0 0;
    }
    ul {
      list-style-type: none;
      padding: 0;
    }
    li {
      display: inline-block;
      margin: 0 10px;
    }
    a {
      color: #42b983;
    }
    #banner {
        margin-bottom: 12px;
        max-height: 20vh;
        padding-top: 13vh;
        padding-bottom: 8vh;
        background-image: radial-gradient(#5347b5,#2ddde0);
    }
    #post {
        margin-bottom: 12px;
        min-height: 40vh;
        padding-top: 0vh;
    }

    #titulo_banner{
        color: white;
    }

    #post-img {
        max-height: 20vh;
    }
</style>
