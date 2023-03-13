using BridgePatternDemo;

MailSendBridge mb = new();
MeetMail objmeet=new MeetMail();
KrupalMail objkrupal=new KrupalMail();

mb.SendFrom(objmeet);
mb.SendFrom(objkrupal);