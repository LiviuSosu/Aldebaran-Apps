
import smtplib
server = smtplib.SMTP('smtp.gmail.com', 587)

#Next, log in to the server
server.login("sosuliviu", "DaciaSandero5$")

#Send the mail
msg = "Hello!" # The /n separates the message from the headers
server.sendmail("sosuliviu@gmail.com", "sosuliviu@example.com", msg)