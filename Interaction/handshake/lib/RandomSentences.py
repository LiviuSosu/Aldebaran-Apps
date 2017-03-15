from random import randint


class RandomSentences:
    hello = ['hi', 'howdy', 'hello']
    shakeHandsPart1 = ["Come on, let's shake hands", "Come on, don't be shy", "I want to shake hands with you"]
    shakeHandsPart2 = [" Are you going to make me wait all day long like this?", "Why are you so shy",
                       "My arm is starting to hurt"]
    shakeHandsGiveUp = ["Well, maybe next time", "Perhaps I did something wrong"]


    def getRandomHello(self):
        random = randint(0, (len(RandomSentences.hello)-1))
        return RandomSentences.hello[random]

    def getRandomShakeHandsSentence1(self):
        random = randint(0, (len(RandomSentences.shakeHandsPart1)-1))
        return "\\rspd = 80\\" + RandomSentences.shakeHandsPart1[random]

    def getRandomShakeHandsSentence2(self):
        random = randint(0, (len(RandomSentences.shakeHandsPart2)-1))
        return "\\rspd = 80\\" + RandomSentences.shakeHandsPart2[random]

    def getRandomShakeHandsGiveUp(self):
        random = randint(0, (len(RandomSentences.shakeHandsGiveUp)-1))
        return "\\rspd = 80\\" + RandomSentences.shakeHandsGiveUp[random]