import requests
import numpy as np
import cv2

addr = 'http://localhost:80/api/detectBear'
addr2 = 'http://localhost:80/api/getStatus'
# addr = 'http://46ac-78-85-48-52.ngrok.io/api/test'
# addr = 'https://polar-bear-server.herokuapp.com/api/detectBear'

headers = {'content-type': 'image/jpeg'}

img = cv2.imread('Bear.jpg')
_, img_encoded = cv2.imencode('.jpg', img)
response = requests.post(addr, data=img_encoded.tobytes(), headers=headers)
response2 = requests.get(addr2)

print(response2.text)

# nparr = np.frombuffer(response.content, np.uint8)
# img_new = cv2.imdecode(nparr, cv2.IMREAD_COLOR)
#
# cv2.imwrite('xd4.jpg', img_new)
