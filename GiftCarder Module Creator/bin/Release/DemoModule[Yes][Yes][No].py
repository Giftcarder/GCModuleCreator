#Module Generated Using Pure's Module Creator
#====== GENERAL SETTINGS ======
name = "DemoModule"
method = 'POST'
pattern = ""
pin = True
cookie = False
token = True
captcha = True
site_key = ""
error = [<Error Key Here>]
retries = 5
timeout = 5
headers = "ExampleHeader"
#====== GENERATING AREA ======
async def cardcode(cardcode = pattern):
for x in range(8):
cardcode += str(randint(0,9))
 return cardcode
async def pincode(pincode = ):
for x in range(4):
pincode += str(randint(0,9))
return pincode
#====== SETTINGS AREA ======
def request():
url = Https://Google.Com
return url
