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

    const image = document.getElementById("kep");
    if(szam==0)
    {
        image.src= "kep1.jpg";
        szam++;
    }
    else if(szam==1)
    {
        image.src= "kep2.jpg";
        szam++;
    }
    else if(szam==2)
    {
        image.src= "kep3.jpg";
        szam++;
    }
    else if(szam==3)
    {
        image.src= "kep4.jpg";
        szam++;
    }
    else if(szam==4)
    {
        image.src= "kep5.jpg";
        szam++;
    }
    else if(szam==5)
    {
        image.src= "sr1.jpg";
        szam++;
    }
}