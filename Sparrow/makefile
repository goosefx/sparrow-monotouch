BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs

all: Sparrow.dll

generate:
	rm -f -r tmp/ 
	mkdir -p tmp/gen/
	$(BTOUCH) ApiDefinition.cs -s=StructsAndEnums.cs --outdir=tmp/gen -ns=Sparrow --unsafe -sourceonly:tmp/genfiles

compile:
	rm -f -r bin/
	mkdir -p bin/
	$(SMCS) /noconfig /debug- /optimize- /out:bin/Sparrow.dll /resource:libSparrow.a libSparrow.linkwith.cs Extras.cs StructsAndEnums.cs `cat tmp/genfiles` /target:library /unsafe+ /reference:/Developer/MonoTouch/usr/lib/mono/2.1/System.dll /reference:/Developer/MonoTouch/usr/lib/mono/2.1/monotouch.dll /reference:/Developer/MonoTouch/usr/lib/mono/2.1/System.Core.dll /warn:4


Sparrow.dll: generate compile

clean: 
	rm -f -r obj/
	rm -f -r tmp/ 