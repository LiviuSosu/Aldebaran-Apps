APP_KEY = "wn2e8WZbAPuknsSLXqiqN5nfg"
APP_SECRET = "HUVqYIygWOhRiNNOgjX2P9GrcgcLHFsCozth6GIwddZ4ie8tLb"
OAUTH_TOKEN = "851336290473832449-H0bVV4wbCCLIMPYpwwpVLIqRTc6wvLD"
OAUTH_TOKEN_SECRET = "3JLIUT0wbEu8M041C1eqJtxWQv6GQcxdZaQTMU30sOoKs"

user = "accenture.bucharest12@gmail.com"
password = "accenture.bucharest123"



image = 'Folder\Subfolder\TestImage.png'
file = open(image, 'rb')
data = file.read()

'''ctr+alt+s -> install -> twython'''

from twython import Twython

twitter = Twython(APP_KEY, APP_SECRET, OAUTH_TOKEN, OAUTH_TOKEN_SECRET)

'''try:
    from TwitterAPI import TwitterAPI
    api = TwitterAPI(APP_KEY, APP_SECRET, OAUTH_TOKEN, OAUTH_TOKEN_SECRET)
    file = open(image, 'rb')
    data = file.read()
    r = api.request('statuses/update_with_media', {'status':'This is done By Liviu S. for the third time'}, {'media[]':data})
    print(r.status_code)
except:
    pass'''

photo = open(image, 'rb')
response = twitter.upload_media(media=photo)
twitter.update_status(status='Checkout this cool image!', media_ids=[response['media_id']])

'''
with open('Folder\Subfolder\TestFile.txt') as fp:
    for line in fp:
        print (line)

'''