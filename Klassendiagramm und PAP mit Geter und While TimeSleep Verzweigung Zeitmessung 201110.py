#import time

class Ventil:
    def oeffnen(self):
        ausgangVentil=1

    def schliessen(self):
        ausgangVentil=0

class Ruehrer:
    def ruehrenEin(self):
        ausgangRuehrer=1

    def ruehrerAus(self):
        ausgangRuehrer=0


class Temperatursensor:
    def __init__(self):
        self.__Solltemperatur

    def getSolltemperatur(self):
        self.__Solltemperatur=eingangSolltemperatur
        return self.__Solltemperatur


class Heizstab:
    def heizenEin(self):
        ausgangHeizstab=1

    def heizenAus(self):
        ausgangHeizstab=0


class Fuellstandsensor:
    def __init__(self):
        self.__Fuellstand

    def getFuellstand(self):
        self.__Fuellstand=eingangFuellstandsensor
        return self.__Fuellstand
		
class Kuehler:
	def __init__(self):
		self.__Kuehlventil
	def kuehlenEin(self):
		self.__Kuehlventil.oeffnen()
	def kuehlenAus(self):
		self.__Kuehlventil.schliessen()

class Vorlage:
	def __init__(self):
		self.__FuellstandssensorVoll
		self.__FuellstandssensorHalbvoll
		self.__FuellstandssensorLeer
		self.__Einlassventil
		self.__Ablassventil
	
	def befuellen(self):
		self.__Einlassventil.oeffnen()
		while self.__FuellstandssensorVoll.getFuellstand()==0
		
		self.__Einlassventil.schliessen()
	
	
	def entleeren(self):
		self.__Ablassventil.oeffnen()
		while self.__FuellstandsensorLeer.getFuellstand()==1:
			
		self.__Ablassventil.schliessen()

class Reaktor(self):
	def __init__(self):
		self.__Ruehrer
		self.__Solltemperatur
		self.__Ablassventil
		self.__FuellstandsensorNichtLeer
		self.__Heizstab
		#self.__Kuehler
		
	def entleeren(self):
		self.__Ablassventil.oeffnen()
		while self.__FuellstandsensorNichtLeer==1:
		
		self.__Ablassventil.schliessen()
		
	def mischen(self):
		self.__Ruehrer.ruehrenEin()
		#Warten
		time.sleep(30)
		self.__Ruehrer.ruehrerAus()
	
	def verestern(self):
		#Verzweigung
		if self.__FuellstandsensorNichtLeer==1
			self.__Ruehrer.ruehrenEin()
			#Kuehler fehlt als Attribut
			self.__Kuehler.kuehlenEin()
			#Zeitmessungstarten
			now = time.localtime(time.time())
			
			#Schleife umdrehen?
			while True:
				self.__Heizstab.heizenEin()
				while self.__Solltemperatur==0:
				
				self.__Heizstab.heizenAus()
				while self.__Solltemperatur==1;
				
				if strftime("%M",now)+20<=strftime("%M",time.localtime(time.time())):
					break
			self.__Kuehler.kuehlenAus();
			self.__Ruehrer.ruehrerAus();

class Veresterungsanlage(self):
	def __init__(self):
		self.__VorlageRechts
		self.__VorlageLinks
		self.__Reaktor
		self.__Kuehler
	
	def einePortionVerestern(self):
		self.__VorlageLinks.befuellen()
		self.__VorlageRechts.befuellen()
		self.__Reaktor.befuellen()
		self.__Reaktor.verestern()
		self.__Reaktor.entleeren()
	
	def reaktorBefuellen(self):
		self.__VorlageLinks.Ablassventil.oeffnen()
		while self.__VorlageLinks.FuellstandsensorHalbVoll==1:
		
		self.__VorlageLinks.Ablassventil.schliessen()
		
		self.__VorlageRechts.Ablassventil.oeffnen()
		while self.__VorlageRechts.FuellstandsensorHalbVoll==1:
		
		self.__VorlageRechts.Ablassventil.schliessen()
		
	
		