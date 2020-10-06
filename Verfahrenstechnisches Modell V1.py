#!/usr/bin/env python2
import RPi.GPIO as GPIO
import time

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

