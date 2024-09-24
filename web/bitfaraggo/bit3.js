function startTime() 
        {
            const today = new Date();
            let h = today.getHours();
            let m = today.getMinutes();
            let s = today.getSeconds();
            m = checkTime(m);
            s = checkTime(s);
            document.getElementById('txt').innerHTML =  h + ":" + m + ":" + s;
            setTimeout(startTime, 1000);
        }

function checkTime(i) 
        {
            if (i < 10)
            {
                i = "0" + i
            };
            return i;
        }


let szam= 0;

function valtozas()
{

    
    if(szam==0)
    {
        var image = document.createElement("img");
        image.setAttribute('src', 'ady.jpg');
        image.setAttribute('id', 'kep');
        image.setAttribute( "display","block")
        image.setAttribute( "margin-left","auto")
        image.setAttribute( "margin-right","auto")
        image.setAttribute('height', '400px');
        image.setAttribute('width', '50px');
        document.body.appendChild(image);
        image.src= "ady.jpg";
        szam++;
    }
    else if(szam==1)
    {
        document.getElementById("kep").src=kep.src.replace("ady.jpg","kep1.jpg")
        szam++;
    }
    else if(szam==2)
    {
        document.getElementById("kep").src=kep.src.replace("kep1.jpg","kep2.jpg")
        szam++;
    }
    else if(szam==3)
    {
        document.getElementById("kep").src=kep.src.replace("kep2.jpg","kep3.jpg")
        szam++;
    }
    else if(szam==4)
    {
        document.getElementById("kep").src=kep.src.replace("kep3.jpg","kep4.jpg")
        szam++;
    }
    else if(szam==5)
    {
        document.getElementById("kep").src=kep.src.replace("kep4.jpg","kep5.jpg")
        szam++;
    }
    else if(szam==6)
    {
        document.getElementById("kep").src=kep.src.replace("kep5.jpg","kep6.jpg")
        szam++;
    }
    else if(szam==7)
    {
        document.getElementById("kep").src=kep.src.replace("kep6.jpg","ady.jpg")
        szam=1;
    }
}
let kattint=0;
function nyomasMate()
{
    if(kattint==0)
    {
        var a=document.createElement("div");
        a.setAttribute("id","nev");
        a.innerHTML="bemutatkozo szoveg";
        document.body.appendChild(a);
    }
}