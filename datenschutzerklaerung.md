# Datenschutzerklärung zum DDF Guide
Der DDF Guide sammelt und/oder speichert keinerlei Nutzerdaten.
Hier folgen lediglich einige Informationen zu den benötigten Android-Berechtigungen.

## *Voller Netwerkzugriff*
Die Informationen zu allen Folgen samt Bildern werden regelmäßig von Github geladen, um den DDF Guide immer aktuell zu halten.
Hierfür wird eine Internetverbindung benötigt. Um den aktuellen Status der Verbindung des Gerätes zu prüfen (WLAN, 
mobiles Internet, kein Internet) und darauf basierend die Daten zu laden, wird die Berechtigung *Voller Netwerkzugriff* benötigt.

## *Beim Gerätestart ausführen*
Der DDF Guide zeigt Benachrichtigungen an, sobald eine neue Folge erscheint. Hierfür läuft im Hintergrund ein Service, der in
regelmäßigen Abständen prüft, ob eine Benachrichtigung nötig ist, oder nicht. Dieser Service wird beim Öffnen der App gestartet.
Wird das Androidgerät jedoch neu gestartet, wird der Service beendet. Um keine Benachrichtigung zu verpassen, wird der Service
daher zusätzlich beim Hochfahren des Androidgerätes gestartet. Hierfür wird die Berechtigung *Beim Gerätestart ausführen* benötigt.

## *Fotos/Medien/Dateien* und *Speicher*
Die Informationen zu allen Folgen samt Bildern werden regelmäßig von Github geladen und lokal auf dem Gerät gespeichert.
Sollte das Gerät offline sein, werden diese lokale Daten geladen. Erst dadurch lässt sich der DDF Guide auch offline komfortabel
nutzen. Um auf die lokalen Dateien zuzugreifen, werden die beiden Berechtigungen *Fotos/Medien/Dateien* und *Speicher* benötigt.
