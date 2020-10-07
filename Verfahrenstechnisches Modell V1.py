#!/usr/bin/env python2
import RPi.GPIO as GPIO
import time

Class Programm:

#
# Setup
#
def setup():
        GPIO.setup(port_or_pin, GPIO.IN, pull_up_down=GPIO.PUD_UP)

	GPIO.setmode(GPIO.BCM)

	RIN0 = 23
	RIN1 = 24
	RIN2 = 25
	RIN3 = 12
	RIN4 = 16
	RIN5 = 20
	RIN6 = 21
	RIN7 = 22

	pumpe   = RIN0
	ventil1 = RIN1
	ventil2 = RIN2
	ventil3 = RIN3
	ventil4 = RIN4
	ventil5 = RIN5
	ventil6 = RIN6
	ventil7 = RIN7

	GPIO.setup(RIN0, GPIO.OUT)
	GPIO.setup(RIN1, GPIO.OUT)
	GPIO.setup(RIN2, GPIO.OUT)
	GPIO.setup(RIN3, GPIO.OUT)
	GPIO.setup(RIN4, GPIO.OUT)
	GPIO.setup(RIN5, GPIO.OUT)
	GPIO.setup(RIN6, GPIO.OUT)
	GPIO.setup(RIN7, GPIO.OUT)

class Veresterungsanlage:
	def __init__ (self):
		self.__vorlageRechts
		self.__vorlageLinks
		self.__reaktor
		self.__kuehler
	
	def EinePortionVerestern(self):
	
		

class Vorlage:
	def __init__(self):
		self.fuelstandssensorVoll
		self.fuelstandssensorHalbvoll
		self.fuelstandssensorLeer
		self.einlassventil
		self.ablassventil
	
	def Entleeren(self):
	
	def Befuellen(self):

class Reaktor:
	def __init__(self):
		self.ruehrer
		self.solltemperatur
		self.ablassventil
		self.fuellstandssensorNichtLeer
		self.heizstab
		
	def Entleeren(self):
	
	def Mischen(self):
	
	def Verestern(self):


class Kuehler:
	def __init__(self):
		self.kuehlventil
		
	def KuehlenEin(self):
	
	def KuehlenAus(self):


class Heizstab:
	def __init__(self):
	
	def HeizenEin(self):
	
	def HeizenAus(self):

class Temperatursensor:
	def __init__(self):
		self.solltemperatur

class Fuellstandssensor:
	def __init__(self):
		self.Fuelstand

class Ruehrer:
	def __init__(self):
	
	def RuehrerEin(self):
	
	def RuehrerAus(self):

class Ventil:
	def __init__(self):
	
	def Oeffnen(self):
	
	def Schliessen(self):

